using UnityEngine;

public class CameraOrthographicSize : MonoBehaviour
{
    private void Awake()
    {
        float screenAspectRatio = (float)(Screen.width / Screen.height);
        float orthographicSize = (float)(6 - (screenAspectRatio - 0.485f) * 11f);
        if(orthographicSize < 4)
        {
            orthographicSize = 4;
        }

        //MainCamera 태그가 붙어있는 카메라 제어
        Camera.main.orthographicSize = orthographicSize;
    }
}
