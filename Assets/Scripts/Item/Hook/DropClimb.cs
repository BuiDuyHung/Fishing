using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropClimb : HookController
{
    public Vector3 hookPosition;
    public override IEnumerator MovePosition()
    {
        isMoving = true;
        yield return new WaitForSeconds(2f);
        climb.enabled = true;

        while (transform.position != hookPosition)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, hookPosition, step);
            yield return null;
        }
    }
}
