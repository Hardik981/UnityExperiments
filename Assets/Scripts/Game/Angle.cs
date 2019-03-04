using UnityEngine;

namespace Game
{
    public class Angle : MonoBehaviour
    {
        public Transform target;
        // Use this for initialization
        void Start () {
        
        }
      
        // Update is called once per frame
        private void Update () {
            Rot2Vec();
        }

        private void Rot2Vec()
        {
            Vector2 direction = new Vector2(
                transform.position.x - target.position.x,
                transform.position.y - target.position.y
            );
            transform.up = direction;
        }
    }
}
