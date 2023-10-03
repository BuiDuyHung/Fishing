using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;

public class HookController : MonoBehaviour
{
    public CinemachineVirtualCamera camera1;
    public CinemachineVirtualCamera camera2;
    public GameObject boatStart;
    public GameObject boatEnd;
    public GameObject morning;
    public GameObject afternoon;

    //sound
    public AudioClip soundHook;
    public AudioClip soundVictory;

    protected float speed = 4;
    public MeshRenderer meshHook;
    public GameObject objectHook;
    private int count = 0;
    private bool isCamera = true;

    protected bool isMoving = false;

    public GameObject shoe;
    public GameObject bag;
    public GameObject watch;
    public GameObject hat;

    protected Vector3 positionHook = new Vector3(1.2f, -5f, 0);
    private Vector3 dragHook = new Vector3(1.2f, 1f, 0);
    private Vector3 endPositionBoat = new Vector3(1f, 6.68f, 0);

    // position shoe
    protected Vector3 shoePosition1 = new Vector3(-1.9f, -5f, 0);
    protected Vector3 shoePosition2 = new Vector3(-1.9f, -8.8f, 0);
    protected Vector3 dragPositionShoe1 = new Vector3(-1.9f, -5f, 0);
    protected Vector3 dragPositionShoe2 = new Vector3(-1.9f, 1, 0);

    // position bag
    protected Vector3 bagPosition2 = new Vector3(1.2f, -8.5f, 0);
    protected Vector3 dargPositionBag1 = new Vector3(1.2f, -5f, 0);
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
        if (Input.GetMouseButtonDown(0))
        {
            if (isCamera)
            {
                camera1.enabled = false;
                camera2.enabled = true;
                isCamera = false;
            }
            else if(count == 4)
            {
                Destroy(objectHook);
                afternoon.SetActive(true);
                boatStart.SetActive(false);
                boatEnd.SetActive(true);
                camera1.enabled = true;
                camera2.enabled = false;
                isCamera = true;

                if (camera1.enabled && !isMoving)
                {
                    StartCoroutine(endBoat());
                }
            }
        }

        if (camera2 != null)
        {
            if (camera2.enabled && !isMoving)
            {
                
                StartCoroutine(MovePosition());
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shoe"))
        {
            collision.transform.SetParent(transform);
            count++;
        }
        else if (collision.CompareTag("bag"))
        {
            collision.transform.SetParent(transform);
            count++;
        }
        else if (collision.CompareTag("watch"))
        {
            collision.transform.SetParent(transform);
            count++;
        }
        else if (collision.CompareTag("hat"))
        {
            collision.transform.SetParent(transform);
            count++;
        }
        
    }

    public IEnumerator dragHookend()
    {
        isMoving = true;
        yield return new WaitForSeconds(2f);
        meshHook.enabled = true;

        while (transform.position != dragHook)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, dragHook, step);
            yield return null;
        }
    }

    private IEnumerator endBoat()
    {
        isMoving = true;
        yield return new WaitForSeconds(2f);

        while (transform.position != endPositionBoat)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, endPositionBoat, step);
            yield return null;
        }
    }

    public virtual IEnumerator MovePosition()
    {
        yield return new WaitForSeconds(2f);
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
