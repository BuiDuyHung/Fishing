using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveHookToShoe : HookController
{
    public AudioSource src;
    public AudioClip shoeSound;

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
        src.clip = shoeSound;
        src.Play();
        yield return new WaitForSeconds(2f);
        src.clip = soundHook;
        src.Play();

        while (objectHook.transform.position != dragPositionShoe2)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dragPositionShoe2, step);
            yield return null;
        }

        Destroy(shoe);
        objectHook.transform.position = positionHook;
        isMoving = false;
    }


}
