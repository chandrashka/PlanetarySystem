using UnityEngine;

namespace Service.Controller
{
    public class RotateAround : MonoBehaviour
    {
        [SerializeField] private Vector3 target;
        [SerializeField] private float degreesPerSecond;

        private System.Random _random;

        private void Start()
        {
            _random = new System.Random();
            degreesPerSecond = _random.Next(180);
        }

        private void Update()
        {
            transform.RotateAround(target, Vector3.down, degreesPerSecond * Time.deltaTime);
        }
    }
}