using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveHookToShoe : HookController
{
    public Vector3 shoePos1;
    public Vector3 shoePos2;
    public Vector3 dragShoe1;
    public Vector3 dragShoe2;

    public GameObject hook;

    private void OnMouseDown()
    {
        StartCoroutine(movePositionShoe());
    }

    public override IEnumerator movePositionShoe()
    {
        isMoving = true;
        while (hook.transform.position != shoePos1)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, shoePos1, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        isMoving = true;

        while (hook.transform.position != shoePos2)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, shoePos2, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);

        while (hook.transform.position != dragShoe1)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, dragShoe1, step);
            yield return null;
        }

        yield return new WaitForSeconds(1f);

        while (hook.transform.position != dragShoe2)
        {
            float step = speed * Time.deltaTime;
            hook.transform.position = Vector3.MoveTowards(hook.transform.position, dragShoe2, step);
            yield return null;
        }

        isMoving = false;
        Destroy(shoe);
    }

}
