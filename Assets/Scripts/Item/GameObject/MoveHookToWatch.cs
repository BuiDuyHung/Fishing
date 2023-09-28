using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHookToWatch : HookController
{
    public Vector3 watchPos1;
    public Vector3 watchPos2;
    public GameObject hook;

    private void OnMouseDown()
    {
        StartCoroutine(movePositionWatch());
    }

    public override IEnumerator movePositionWatch()
    {
        isMoving = true;
        while (hook.transform.position != watchPos1)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, watchPos1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        isMoving = true;

        while (hook.transform.position != watchPos2)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, watchPos2, step);
            yield return null;
        }
    }
}
