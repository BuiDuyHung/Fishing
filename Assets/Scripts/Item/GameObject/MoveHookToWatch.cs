using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveHookToWatch : GameController
{
    public AudioSource src;
    public AudioClip watchSound;
    public TextMeshProUGUI txtWatch;
    public GameObject watch;

    private void OnMouseDown()
    {
        StartCoroutine(movePositionWatch());

    }

    public override IEnumerator movePositionWatch()
    {
        isMoving = true;
        while (objectHook.transform.position != watchPosition1)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, watchPosition1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.2f);

        while (objectHook.transform.position != watchPosition2)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, watchPosition2, step);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        src.clip = soundHook;
        src.Play();

        while (objectHook.transform.position != dargPositionWatch1)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dargPositionWatch1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        txtWatch.SetText("WATCH");
        src.clip = watchSound;
        src.Play();

        yield return new WaitForSeconds(2f);
        txtWatch.SetText("");
        src.clip = soundHook;
        src.Play();

        while (objectHook.transform.position != dargPositionWatch2)
        {
            float step = speed * Time.deltaTime;
            objectHook.transform.position = Vector3.MoveTowards(objectHook.transform.position, dargPositionWatch2, step);
            yield return null;
        }

        Destroy(watch);
        objectHook.transform.position = positionHook;
        isMoving = false;
    }
}
