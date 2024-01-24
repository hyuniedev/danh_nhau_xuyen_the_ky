using UnityEngine;

namespace DefaultNamespace
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] private float heart = 100;
        [SerializeField] private float speed = 2f;
        [SerializeField] private float tamdanh = 1f;
        [SerializeField] private float dame = 10f;
        
        public float Heart
        {
            get => heart;
            set => heart = value;
        }

        public float Speed
        {
            get => speed;
            set => speed = value;
        }

        public float Tamdanh
        {
            get => tamdanh;
            set => tamdanh = value;
        }

        public float Dame
        {
            get => dame;
            set => dame = value;
        }
    }
}