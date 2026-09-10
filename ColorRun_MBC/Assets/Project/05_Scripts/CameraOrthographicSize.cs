using UnityEngine;

public class CameraOrthographicSize : MonoBehaviour
{
    [SerializeField] private bool autoAdjustOrthographicSize = false;

    private void Awake()
    {
        // Preserve the camera size configured in the scene unless explicitly enabled.
        if (!autoAdjustOrthographicSize) return;

        float screenAspectRatio = (float)Screen.width / Screen.height;
        float orthographicSize = (float)(6 - (screenAspectRatio - 0.485f) * 11f);
        if(orthographicSize < 4)
        {
            orthographicSize = 4;
        }

        //MainCamera 태그가 붙어있는 카메라 제어
        Camera.main.orthographicSize = orthographicSize;
    }
}
