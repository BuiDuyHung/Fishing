using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHookToBag : HookController
{
    public Vector3 bagPos1;
    public Vector3 bagPos2;
    public GameObject hook;

    private void OnMouseDown()
    {
        StartCoroutine(movePositionBag());
    }

    public override IEnumerator movePositionBag()
    {
        isMoving = true;
        while (hook.transform.position != bagPos1)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, bagPos1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        isMoving = true;

        while (hook.transform.position != bagPos2)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, bagPos2, step);
            yield return null;
        }
    }

}
