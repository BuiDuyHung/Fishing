using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFish1 : MoveScript
{
    public override void move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
