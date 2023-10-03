using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHook : HookController
{
    public AudioSource src;
    public AudioClip learnSound;

    public override IEnumerator MovePosition()
    {
        isMoving = true;
        yield return new WaitForSeconds(2f);
        meshHook.enabled = true;

        src.clip = soundHook;
        src.Play();

        while (transform.position != positionHook)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, positionHook, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.2f);
        src.clip = learnSound;
        src.Play();
    }
}
