using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScaler : MonoBehaviour
{
    private float targetAspectRatio = 1920f / 1080f;
    new private Camera camera;

    private void Start()
    {
        camera = GetComponent<Camera>();
        camera.aspect = targetAspectRatio;
    }
}
