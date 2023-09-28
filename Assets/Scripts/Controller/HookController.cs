using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;

public class HookController : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera2;
    public float speed;
    public MeshRenderer climb;

    protected bool isMoving = false;
    private bool isAttached = false;

    public GameObject shoe;
    public GameObject bag;
    public GameObject watch;
    public GameObject hat;
    

    void Start()
    {
        
    }
    
    void Update()
    {
        if (virtualCamera2 != null)
        {
            if (virtualCamera2.enabled && !isMoving)
            {
                StartCoroutine(MovePosition());
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!isAttached && collision.CompareTag("shoe"))
        {
            bag.SetActive(false);
            watch.SetActive(false);
            hat.SetActive(false);

            collision.transform.SetParent(transform);
            isAttached = true;
            StartCoroutine(movePositionShoe());
            
        }

        if (!isAttached && collision.CompareTag("bag"))
        {

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
