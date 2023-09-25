using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFish2 : MoveScript
{
    public override void move()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
