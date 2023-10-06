using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;


public class NextCamera : GameController
{
    private float speedCamera = 0.5f;
    private bool isCam = true;
    public Button btnStart;
    public override IEnumerator moveCamera()
    {
        isMoving = true;
        yield return new WaitForSeconds(5f);

        while (transform.position != positionCamera)
        {
            float step = speedCamera * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, positionCamera, step);
            yield return null;
        }
    }

    public void startGame()
    {
        if (isCam)
        {
            btnStart.enabled = false;
            camera1.enabled = false;
            camera2.enabled = true;
            isCam = false;
        }
    }

}
