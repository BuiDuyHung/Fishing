using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class NextCamera : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera1;
    public CinemachineVirtualCamera virtualCamera2;
    private bool isCamera = true;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //virtualCamera1.enabled = false;
            // virtualCamera2.enabled = true;
            if (isCamera)
            {
                virtualCamera1.enabled = false;
                virtualCamera2.enabled = true;
                isCamera = false;
            }
            /*else
            {
                virtualCamera1.enabled = true;
                virtualCamera2.enabled = false;
                isCamera = true;
            }*/
        }
        
    }
}
