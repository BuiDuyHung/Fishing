using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatEnd : GameController
{

    private void Update()
    {
        StartCoroutine(moveBoatEnd());
    }

    public override IEnumerator moveBoatEnd()
    {
        isMoving = true;
        yield return new WaitForSeconds(2f);

        while (boatEnd.transform.position != endPositionBoat)
        {
            float step = speed * Time.deltaTime;
            boatEnd.transform.position = Vector3.MoveTowards(boatEnd.transform.position, endPositionBoat, step);
            yield return null;
        }
    }
}
