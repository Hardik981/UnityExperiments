using UnityEngine;

namespace Touch
{
    public class TouchScript : MonoBehaviour
    {
        private Camera _camera;
        private bool _isCameraNotNull;
        private Vector2 _start;
        private Vector2 _end;

        // Start is called before the first frame update
        private void Start()
        {
            _camera = Camera.main;
            _isCameraNotNull = _camera != null;        
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.touchCount > 0)
            {
                var touch = Input.GetTouch(0);
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        if (_isCameraNotNull)
                        {
                            _start = _camera.ScreenToWorldPoint(touch.position);
                            print("Start: "+_start);
                        }
                        break;
                    case TouchPhase.Ended:
                        _end = _camera.ScreenToWorldPoint(touch.position);
                        print("End: "+_end);
                        DecideDir();
                        break;
                }
            }
        }
        private void DecideDir()
        {
            if (_start.x > _end.x && Mathf.Abs(_start.y - _end.y) <= 1.5f)
                print("Left");
            else if (_start.x < _end.x && Mathf.Abs(_start.y - _end.y) <= 1.5f)
                print("Right");
        }
    }
}
