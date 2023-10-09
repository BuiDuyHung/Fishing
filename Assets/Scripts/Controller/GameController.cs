using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;
using TMPro;

public class GameController : MonoBehaviour
{
    public CinemachineVirtualCamera camera1;
    public CinemachineVirtualCamera camera2;
    public GameObject boatStart;
    public GameObject boatEnd;
    public GameObject morning;
    public GameObject afternoon;
    //private float currentTime = 5f;

    
    //public TextMeshProUGUI txtGame;

    //sound
    public AudioClip soundHook;
    public AudioClip soundVictory;

    protected float speed = 4;
    public MeshRenderer meshHook;
    

    public GameObject objectHook;
    private bool isCamera = true;

    protected bool isMoving = false;
    protected bool isDraggingObject = false;
    protected bool isDragging = false;

    protected Vector3 positionHook = new Vector3(1.2f, -5f, 0);

    protected Vector3 endPositionBoat = new Vector3(17f, 2.5f, 0);
    protected Vector3 positionCamera = new Vector3(0.89f, -5.42f, -16.59399f);

    // position shoe
    protected Vector3 shoePosition1 = new Vector3(-1.9f, -5f, 0);
    protected Vector3 shoePosition2 = new Vector3(-1.9f, -8.8f, 0);
    protected Vector3 dragPositionShoe1 = new Vector3(-1.9f, -5f, 0);
    protected Vector3 dragPositionShoe2 = new Vector3(-1.9f, 1f, 0);
    protected Vector3 dragPositionShoe3 = new Vector3(1.2f, 1f, 0);

    // position bag
    protected Vector3 bagPosition2 = new Vector3(1.2f, -8.5f, 0);
    protected Vector3 dargPositionBag1 = new Vector3(1.2f, -4f, 0);
    protected Vector3 dragPositionBag2 = new Vector3(1.2f, 1f, 0);

    // position watch
    protected Vector3 watchPosition1 = new Vector3(4.3f, -5f, 0);
    protected Vector3 watchPosition2 = new Vector3(4.3f, -9.5f, 0);
    protected Vector3 dargPositionWatch1 = new Vector3(4.3f, -5f, 0);
    protected Vector3 dargPositionWatch2 = new Vector3(4.3f, 1f, 0);

    // position hat
    protected Vector3 hatPosition1 = new Vector3(7f, -5, 0);
    protected Vector3 hatPosition2 = new Vector3(7f, -9.3f, 0);
    protected Vector3 dragPositionHat1 = new Vector3(7f, -5f, 0);
    protected Vector3 dragPositionHat2 = new Vector3(7f, 1f, 0);


    void Update()
    {
        //currentTime -= 1 * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            if (isCamera)   
            {
                camera1.enabled = false;
                camera2.enabled = true;
                isCamera = false;
            }

        }

    }


    public virtual IEnumerator moveCamera()
    {
        yield return new WaitForSeconds(2f);
    }

    public virtual IEnumerator moveBoatEnd()
    {
        yield return new WaitForSeconds(2f);
    }

    public virtual IEnumerator MovePosition()
    {
        yield return null;
    }

    public virtual IEnumerator movePositionShoe()
    {
        yield return new WaitForSeconds(2f);
    }

    public virtual IEnumerator movePositionBag()
    {
        yield return new WaitForSeconds(2f);
    }

    public virtual IEnumerator movePositionWatch()
    {
        yield return new WaitForSeconds(2f);
    }

    public virtual IEnumerator movePositionHat()
    {
        yield return new WaitForSeconds(2f);
    }

    
}
