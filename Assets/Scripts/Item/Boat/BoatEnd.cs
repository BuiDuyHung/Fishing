using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatEnd : GameController
{
    public bool isMovingBoat = false;


    private void Update()
    {
        if (camera1 != null)
        {
            if (camera1.enabled && !isMoving)
            {
                StartCoroutine(moveBoatEnd());
            }
        }
       
    }

    public override IEnumerator moveBoatEnd()
    {
        isMoving = true;
        yield return new WaitForSeconds(7f);

        while (boatEnd.transform.position != endPositionBoat)
        {
            float step = speed * Time.deltaTime;
            boatEnd.transform.position = Vector3.MoveTowards(boatEnd.transform.position, endPositionBoat, step);
            yield return null;
        }
    }
}
