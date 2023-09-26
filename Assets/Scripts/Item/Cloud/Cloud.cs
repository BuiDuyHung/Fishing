using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : ItemGenerate
{
    public override void SpawnItem()
    {
        GameObject item = Instantiate(itemGenerate, new Vector3(19f, 8.1f, 0), Quaternion.identity);
        Destroy(item, 10f);
    }
}
