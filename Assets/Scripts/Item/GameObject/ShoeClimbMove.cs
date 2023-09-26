using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeClimbMove : HookController
{
    public Vector3 shoePos1;
    public Vector3 shoePos2;

    public override IEnumerator movePositionShoe()
    {
        climb.enabled = true;
        isMoving = true;
        while (transform.position != shoePos1)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, shoePos1, step);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        isMoving = true;

        while (transform.position != shoePos2)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, shoePos2, step);
            yield return null;
        }
    }

}
