using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraR : MonoBehaviour
{
    private float defaultSize = 5;
    void Start()
    {
        float ratio = (float)Screen.width/ Screen.height;

        GetComponent<Camera>().orthographicSize = (0.6f / ratio) * 5;
    }

}
