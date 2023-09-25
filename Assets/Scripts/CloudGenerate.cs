using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CloudGenerate : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera1;
    public GameObject cloudPrefab;
    public float timeDuration = 0;
    private float timer;

    private void Start()
    {
        timer = timeDuration; 
    }

    void Update()
    {
        if (virtualCamera1.enabled == true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                SpawnCloud();
                timer = timeDuration + 3f;
            }
        }
    }

    void SpawnCloud()
    {
        GameObject newCloud = Instantiate(cloudPrefab, new Vector3(19f, 8.1f, 0), Quaternion.identity);
        Destroy(newCloud, 10f); 
    }
    
}
