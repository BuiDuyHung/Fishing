using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public int speed;

    void Update()
    {
        move();
    }

    public virtual void move() { }
    
}
