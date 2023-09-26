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

    public void hookMoveShoe()
    {
        Debug.Log("click");
        if (Input.GetMouseButtonDown(0) && climb.enabled == true)
        {
            movePositionShoe();
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

    
}
