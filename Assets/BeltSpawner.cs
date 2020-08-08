using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class BeltSpawner : MonoBehaviour
    {
        [Header("Spawner Settings")]
        public GameObject AsteroidPrefab;
        public int AsteroidDensity;
        public int Seed;
        public float InnerRadius;
        public float OuterRadius;
        public float Height;
        public bool RotatingClockwise;

        [Header("Asteroid Settings")]
        public float MinOrbitalSpeed;
        public float MaxOrbitalSpeed;
        public float MinRotationSpeed;
        public float MaxRotationSpeed;

        private Vector3 localPosition;
        private Vector3 worldOffset;
        private Vector3 worldPosition;
        private float randomRadius;
        private float randomRadian;
        private float x;
        private float y;
        private float z;
    }
}