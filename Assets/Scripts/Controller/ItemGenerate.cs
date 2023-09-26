using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ItemGenerate : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera1;
    public CinemachineVirtualCamera virtualCamera2;
    public GameObject itemGenerate;
    public float timeDuration = 0;
    public float timePlus;

    private float timer;

    void Start()
    {
        timer = timeDuration;
    }
    
    void Update()
    {
        if (virtualCamera1.enabled == true || virtualCamera2.enabled == true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                SpawnItem();
                timer = timeDuration + timePlus;
            }
        }
    }

    public virtual void SpawnItem() { }

   
}
