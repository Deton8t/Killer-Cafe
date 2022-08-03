using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public GameObject inventory;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void display()
    {
        this.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void hide()
    {
        this.transform.localScale = new Vector3(0, 1f, 1f);
    }


}
