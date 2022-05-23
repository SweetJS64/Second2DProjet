using UnityEngine;

public class CameraDetectionFPS : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
}
