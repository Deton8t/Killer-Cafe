using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCharacterController : MonoBehaviour
{

    public KeyCode inventory;
    public bool invOpen;
    public InventoryController invController;

    void Start()
    {
        if (itemTracker.fromRoom1)
        {
            this.transform.position = new Vector3(2f, this.transform.position.y, 0);
        }
        inventory = KeyCode.I;
        itemTracker.fromRoom1 = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(inventory))
        {
            if (invOpen)
            {
                invController.hide();
                invOpen = false;
            }
            else
            {
                invController.display();
                invOpen = true;
            }

        }
    }




}
