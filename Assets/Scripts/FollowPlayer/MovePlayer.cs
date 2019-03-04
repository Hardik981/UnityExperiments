using UnityEngine;

namespace FollowPlayer
{
    public class MovePlayer : MonoBehaviour
    {
        private readonly Vector2 _up = new Vector2(0,3);
        private readonly Vector2 _right = new Vector2(3,0);
        private Rigidbody2D _rb;
        // Start is called before the first frame update
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            Debug.Log("GameObject1 collided with " + col.name);
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKey(KeyCode.A))              //Run code in loop when key is pressed
            {
                _rb.AddRelativeForce(-_right);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _rb.AddRelativeForce(_right);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                _rb.AddRelativeForce(_up);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                _rb.AddRelativeForce(-_up);
            }
        
        }
    }
}
