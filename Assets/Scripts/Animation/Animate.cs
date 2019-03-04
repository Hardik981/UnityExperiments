using UnityEngine;

namespace Animation
{
    public class Animate : MonoBehaviour
    {

        public void Left()
        {
            transform.localScale = new Vector3(3,1,1);
        }

        public void Right()
        {
            transform.localScale = new Vector3(3,5,1);
        }
        public void Idle(){
            transform.localScale = new Vector3(5,3,1);
        }
    }
}
