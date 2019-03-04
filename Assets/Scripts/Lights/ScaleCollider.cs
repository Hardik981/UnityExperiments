using UnityEngine;

namespace FollowPlayer
{
    public class ScaleCollider : MonoBehaviour
    {
        [SerializeField] private CircleCollider2D cc;

        [SerializeField] private Light l;
        // Start is called before the first frame update
        private void Start()
        {
            cc.radius = l.range/2.35f;
        }
    }
}
