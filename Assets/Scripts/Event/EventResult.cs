using UnityEngine;

namespace Event
{
    public class EventResult : MonoBehaviour
    {
        public GameObject other;                   
        private EventCheck _ec;

        private void Start()
        {
            _ec = other.GetComponent<EventCheck>();
            _ec.Pe += Result;
        }

        private static void Result()
        {
            Debug.Log("Hit");
        }
    }
}
