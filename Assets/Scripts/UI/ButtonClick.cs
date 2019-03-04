using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ButtonClick : MonoBehaviour
    {
        private Text _text;
        private GameObject _textGo;
        [SerializeField] private Canvas canvasGo;
        // Start is called before the first frame update
        public void On()
        {
            var arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        
            // Create the Text GameObject.
            _textGo = new GameObject("Reaction");
            _textGo.transform.parent = canvasGo.transform;
            _textGo.AddComponent<Text>();
        
            // Set Text component properties.
            _text = _textGo.GetComponent<Text>();
            _text.font = arial;
            _text.text = "Pointed";
            _text.fontSize = 40;
            _text.alignment = TextAnchor.MiddleCenter;
            _text.resizeTextForBestFit = true;
        
            // Provide Text position and size using RectTransform.
            RectTransform rectTransform;
            rectTransform = _text.GetComponent<RectTransform>();
            rectTransform.localPosition = new Vector3(-247, -33,0);
            rectTransform.sizeDelta = new Vector2(106.18f,16.38f);
        
        }

        public void Off()
        {
            Destroy(_textGo);
        }
    }
}
