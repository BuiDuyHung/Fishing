using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : ItemGenerate
{
    public override void SpawnItem()
    {
        GameObject item = Instantiate(itemGenerate, new Vector3(0.8837f, 1.3865f, 0), Quaternion.identity);
        Destroy(item, 10f);
    }
}
