using UnityEngine;

namespace Game
{
    public class MultiRes : MonoBehaviour
    {
        private Camera _cam;
        private Vector3 _size;

        private void Awake()
        {
            _cam = Camera.main;
            if (_cam != null) _size = _cam.ScreenToWorldPoint(new Vector3(_cam.pixelWidth, _cam.pixelHeight, 0));
            Debug.Log(_size);
            var transformVar = transform;
            transformVar.localScale = new Vector3(0.15f*_size.x,0.2f*_size.y,0);
            transformVar.position = new Vector3(-0.5f*_size.x,0.8f*_size.y,0); 
            //In Position, x = -0.9 means left, x = 0.9 means right, y = 0.9 means top, y = -0.9 means down  
        }
    }
}
