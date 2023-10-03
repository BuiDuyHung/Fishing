using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHookToHat : HookController
{
    public AudioSource src;
    public AudioClip hatSound;

    private void OnMouseDown()
    {
        StartCoroutine(movePositionHat());
    }

    public override IEnumerator movePositionHat()
    {
        isMoving = true;
        while (objectHook.transform.position != hatPosition1)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, hatPosition1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.2f);

        while (objectHook.transform.position != hatPosition2)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, hatPosition2, step);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        src.clip = soundHook;
        src.Play();

        while (objectHook.transform.position != dragPositionHat1)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dragPositionHat1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        src.clip = hatSound;
        src.Play();
        yield return new WaitForSeconds(2f);
        src.clip = soundHook;
        src.Play();

        while (objectHook.transform.position != dragPositionHat2)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dragPositionHat2, step);
            yield return null;
        }

        Destroy(hat);
        objectHook.transform.position = positionHook;
        isMoving = false;
        
    }
}
