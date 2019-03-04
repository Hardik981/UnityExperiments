using UnityEngine;

namespace Event
{
    public class EventCheck : MonoBehaviour
    {
        public Transform other;
        private readonly float _dis = Screen.height;
    
        public delegate void Pd();
        public event Pd Pe;  // it start Player Bullet

        private void Update()
        {
            var hit = Physics2D.Raycast(other.position, transform.up,_dis);
            if (hit)
                if (hit.collider.name == "Enemy")
                    if(Pe != null) Pe();
                    else 
                        Debug.Log("Not Hit Other");
                else
                    Debug.Log("Not Hit Anything");
        }
    }
}
