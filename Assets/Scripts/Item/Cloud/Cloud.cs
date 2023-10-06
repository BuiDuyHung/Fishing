using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : ItemGenerate
{
    public override void SpawnItem()
    {
        GameObject item = Instantiate(itemGenerate, new Vector3(-18f, 8.1f, -3f), Quaternion.identity);
        Destroy(item, 10f);
    }
}
