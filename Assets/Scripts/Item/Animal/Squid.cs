using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squid : ItemGenerate
{
    public override void SpawnItem()
    {
        GameObject item = Instantiate(itemGenerate, new Vector3(Random.Range(-7.1f, 5f), -10f, 0), Quaternion.identity);
        Destroy(item, 10f);
    }
}
