using UnityEngine;
using UnityEngine.InputSystem;

namespace LunaWolf.Polyquest
{
    [RequireComponent(typeof(CharacterController))]
    public sealed class ShowcasePlayer : MonoBehaviour
    {
        [SerializeField] Camera followCamera;
        [SerializeField] Transform[] collectibles;
        [SerializeField] Transform goal;
        [SerializeField] Vector3 spawn;
        [SerializeField] float fallHeight = -8f;

        CharacterController controller;
        float verticalSpeed;
        float yaw;
        int collected;
        bool reachedGoal;

        public void Configure(Camera camera, Transform[] pickups, Transform summit, Vector3 start)
        {
            followCamera = camera;
            collectibles = pickups;
            goal = summit;
            spawn = start;
        }

        void Awake()
        {
            controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            var keyboard = Keyboard.current;
            if (keyboard == null || followCamera == null)
                return;

            if (Mouse.current != null && Mouse.current.rightButton.isPressed)
                yaw += Mouse.current.delta.x.ReadValue() * 0.16f;
            float horizontal = (keyboard.dKey.isPressed ? 1 : 0) - (keyboard.aKey.isPressed ? 1 : 0);
            float forward = (keyboard.wKey.isPressed ? 1 : 0) - (keyboard.sKey.isPressed ? 1 : 0);
            Vector3 input = Vector3.ClampMagnitude(new Vector3(horizontal, 0, forward), 1);
            Vector3 direction = Quaternion.Euler(0, yaw, 0) * input;
            if (controller.isGrounded)
                verticalSpeed = keyboard.spaceKey.wasPressedThisFrame ? 8.2f : -2f;

            float dt = Time.deltaTime;
            verticalSpeed -= 20f * dt;
            controller.Move((direction * 6.4f + Vector3.up * verticalSpeed) * dt);
            if (input.sqrMagnitude > 0.01f)
                transform.rotation = Quaternion.LookRotation(direction);

            if (transform.position.y < fallHeight || keyboard.rKey.wasPressedThisFrame)
            {
                controller.enabled = false;
                transform.position = spawn;
                controller.enabled = true;
                verticalSpeed = 0;
            }

            foreach (var pickup in collectibles)
            {
                if (!pickup.gameObject.activeSelf)
                    continue;
                pickup.Rotate(0, 75f * dt, 0, Space.World);
                if ((pickup.position - transform.position).sqrMagnitude > 1.65f * 1.65f)
                    continue;
                pickup.gameObject.SetActive(false);
                collected++;
            }

            if (goal != null && Vector3.Distance(goal.position, transform.position) < 2f)
                reachedGoal = true;
        }

        void LateUpdate()
        {
            if (followCamera == null)
                return;
            var lookAt = transform.position + Vector3.up * 0.8f;
            var direction = Quaternion.Euler(0, yaw, 0) * new Vector3(0, 3.8f, -7.5f);
            if (Physics.SphereCast(lookAt, 0.18f, direction.normalized, out var hit, direction.magnitude,
                    ~LayerMask.GetMask("Ignore Raycast"), QueryTriggerInteraction.Ignore))
                direction = direction.normalized * Mathf.Max(0.6f, hit.distance - 0.2f);
            followCamera.transform.position = lookAt + direction;
            followCamera.transform.LookAt(lookAt + Vector3.up * 0.4f);
        }

        void OnGUI()
        {
            GUI.Box(new Rect(18, 18, 340, 65), "");
            GUI.Label(new Rect(30, 26, 320, 26), "WASD Move    Space Jump    RMB Orbit    R Reset");
            GUI.Label(new Rect(30, 49, 320, 26),
                $"Relics {collected}/{collectibles.Length}   {(reachedGoal ? "Summit reached" : "Find a route to the summit")}");
        }
    }
}
