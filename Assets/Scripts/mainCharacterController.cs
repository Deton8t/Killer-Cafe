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
        inventory = KeyCode.I;
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
