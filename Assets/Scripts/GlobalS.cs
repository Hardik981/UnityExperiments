using UnityEngine;

public class GlobalS : MonoBehaviour
{
    private static readonly Camera Cam = Camera.main;
    public static readonly Vector3 Size = Cam.ScreenToWorldPoint(new Vector3(Cam.pixelWidth,Cam.pixelHeight,0));

}
