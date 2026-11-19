using UnityEngine;
using UnityEngine.AI;

namespace MovingViolation.Audio
{
    public sealed class TrialNavigation : MonoBehaviour
    {
        public NavMeshData Data;
        private NavMeshDataInstance instance;
        private void OnEnable()
        {
            if (Data) instance = NavMesh.AddNavMeshData(Data);
        }

        private void OnDisable()
        {
            if (instance.valid) instance.Remove();
        }
    }
}
