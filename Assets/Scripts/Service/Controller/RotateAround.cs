using Constants;
using Service.Random;
using UnityEngine;

namespace Service.Controller
{
    public class RotateAround : MonoBehaviour
    {
        [SerializeField] private Vector3 target;
        [SerializeField] private float degreesPerSecond;

        private void Start()
        {
            degreesPerSecond = RandomExtensions.Random.Next(GameConstants.Planetary.MaximumDegreesPerSecond);
        }

        private void Update()
        {
            transform.RotateAround(target, Vector3.down, degreesPerSecond * Time.deltaTime);
        }
    }
}