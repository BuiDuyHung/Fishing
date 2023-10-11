using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHook : GameController
{
    public AudioSource src;
    public AudioClip learnSound;
    private int countOb = 0;


    private void Update()
    {
        if (camera2 != null)
        {
            if (camera2.enabled && !isMoving)
            {
                StartCoroutine(MovePosition());
            }
        }

        if (countOb == 4)
        {
            afternoon.SetActive(true);

            if (Input.GetMouseButtonDown(0))
            {
                objectHook.SetActive(false);
                boatEnd.SetActive(true);

                camera1.enabled = true;
                camera2.enabled = false;

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shoe") || collision.CompareTag("bag") || collision.CompareTag("watch") || collision.CompareTag("hat"))
        {
            collision.transform.SetParent(transform);
            countOb++;
        }

    }

    public override IEnumerator MovePosition()
    {
        isMoving = true;
        yield return new WaitForSeconds(2f);
        meshHook.enabled = true;

        src.clip = soundHook;
        src.Play();

        while (transform.position != positionHook)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, positionHook, step);
            yield return null;
        }

        yield return new WaitForSeconds(0.3f);
        src.clip = learnSound;
        src.Play();
    }
}
