using UnityEngine;

public class Rotation : MonoBehaviour
    {
        private Rigidbody2D _rb2D;

        void Start()
        {
            _rb2D = GetComponent<Rigidbody2D>();
            //_rb2D.rotation = 45f;
        }

        void FixedUpdate()
        {
            _rb2D.rotation += 1.0f;
        }
    }
