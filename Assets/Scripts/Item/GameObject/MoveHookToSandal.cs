using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoveHookToSandal : GameController
{
    public AudioSource src;
    public AudioClip sandalSound;
    public TextMeshProUGUI txtSandal;
    public GameObject shoe;


    private void OnMouseDown()
    {
        StartCoroutine(movePositionShoe());
    }


    public override IEnumerator movePositionShoe()
    {
        isMoving = true;
        while (objectHook.transform.position != shoePosition1)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, shoePosition1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.2f);


        while (objectHook.transform.position != shoePosition2)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, shoePosition2, step);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        src.clip = soundHook;
        src.Play();


        while (objectHook.transform.position != dragPositionShoe1)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dragPositionShoe1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        txtSandal.SetText("SANDAL");
        src.clip = sandalSound;
        src.Play();
        yield return new WaitForSeconds(2f);
        txtSandal.SetText("");
        src.clip = soundHook;
        src.Play();

        while (objectHook.transform.position != dragPositionShoe2)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dragPositionShoe2, step);
            yield return null;
        }

        while (objectHook.transform.position != dragPositionShoe3)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dragPositionShoe3, step);
            yield return new WaitForFixedUpdate();
        }

        if (shoe != null)
        {
            shoe.SetActive(false); 
        }

        
        objectHook.transform.position = positionHook;
        isMoving = false;
    }

    
}
