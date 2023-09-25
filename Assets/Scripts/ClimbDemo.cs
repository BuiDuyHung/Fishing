using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbDemo : ItemGenerate
{
    public override void SpawnItem()
    {
        GameObject newCloud = Instantiate(itemGenerate, new Vector3(0.57f, 9.06f, 0), Quaternion.identity);
    }
}
