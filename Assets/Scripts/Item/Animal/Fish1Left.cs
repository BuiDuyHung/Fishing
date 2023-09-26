using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish1Left : ItemGenerate
{
    public override void SpawnItem()
    {
        GameObject item = Instantiate(itemGenerate, new Vector3(-8.5f, Random.Range(-2f, -4f), 0), Quaternion.identity);
        Destroy(item, 25f);
    }
}
