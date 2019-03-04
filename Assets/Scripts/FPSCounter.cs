using System.Collections;
using UnityEngine;

public class FrameCounter : MonoBehaviour
{
    private int _frameCount = 0;
    private void Start()
    {
        StartCoroutine(Fps());
    }

    private void Update()
    {
        _frameCount++;
    }
    
    private IEnumerator Fps()
    {
        while (true)
        {
            _frameCount = 0;
            yield return new WaitForSeconds(1.0f);
        }
    }

}

