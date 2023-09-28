using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject shoe;

    // Start is called before the first frame update
    void Start()
    {
        shoe.GetComponent<Button>().onClick.AddListener(MoveHookToShoe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveHookToShoe()
    {
        Debug.Log("click shoe");
    }
}
