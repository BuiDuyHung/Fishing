using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHook : MoveScript
{
    public override void move()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
