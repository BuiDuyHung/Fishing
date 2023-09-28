using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHookToHat : HookController
{
    public Vector3 hatPos1;
    public Vector3 hatPos2;
    public GameObject hook;

    private void OnMouseDown()
    {
        StartCoroutine(movePositionHat());
    }

    public override IEnumerator movePositionHat()
    {
        isMoving = true;
        while (hook.transform.position != hatPos1)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, hatPos1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        isMoving = true;

        while (hook.transform.position != hatPos2)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, hatPos2, step);
            yield return null;
        }
    }
}
