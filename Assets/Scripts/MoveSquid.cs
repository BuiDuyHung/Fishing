using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquid : MoveScript
{
    public override void move()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
