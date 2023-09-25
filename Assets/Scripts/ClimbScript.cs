using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ClimbScript : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera2; 
    public GameObject climbPrefab;
    public float timeDuration = 0;
    public float timePlus;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (virtualCamera2.enabled == true)
        {
            moveClimb();
        }
    }

    public void moveClimb()
    {
        GameObject newCloud = Instantiate(climbPrefab, new Vector3(0.57f, 9.06f, 0), Quaternion.identity);
    }
}
