using UnityEngine;

namespace Lights
{
    public class ScaleLight : MonoBehaviour
    {
        [SerializeField] private Transform light0T;        
        // Start is called before the first frame update
        private void Start()
        {
            var cam = Camera.main;
            Functions2D.RelativeTransform(light0T,"pos",-0.4f,0.3f);
            Functions2D.RelativeTransform(light0T,"scale",0.05f,0.1f);
        }
    }
}
