using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHookToBag : HookController
{
    public AudioSource src;
    public AudioClip BagSound;

    private void OnMouseDown()
    {
        StartCoroutine(movePositionBag());
    }

    public override IEnumerator movePositionBag()
    {
        isMoving = true;
        yield return new WaitForSeconds(0.2f);

        while (objectHook.transform.position != bagPosition2)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, bagPosition2, step);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        src.clip = soundHook;
        src.Play();

        while (objectHook.transform.position != dargPositionBag1)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dargPositionBag1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        src.clip = BagSound;
        src.Play();
        yield return new WaitForSeconds(2f);
        src.clip = soundHook;
        src.Play();

        while (objectHook.transform.position != dragPositionBag2)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dragPositionBag2, step);
            yield return null;
        }

        Destroy(bag);
        objectHook.transform.position = positionHook;
        isMoving = false;
    }

}
