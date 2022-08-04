using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyKey : MonoBehaviour
{

    public string interactText;
    public string lookAtText;
    public bool isColliding;
    public TextHandler textBox;
    public KeyCode interact;
    public KeyCode lookAt;
    public int interactCount;
    public itemSpawner spawner;



    // Start is called before the first frame update
    void Start()
    {
        interact = KeyCode.E;
        lookAt = KeyCode.F;

    }

    // Update is called once per frame
    void Update()
    {
        if (isColliding)
        {
            if (Input.GetKeyDown(interact))
            {
                textBox.displayText(interactText);
                itemTracker.hasItem2 = true;
                spawner.loadItem();
            }

            if (Input.GetKeyDown(lookAt))
            {
                textBox.displayText(lookAtText);
            }
            else
            {

            }
        }
        else
        {

        }
    }

    void OnTriggerEnter2D()
    {
        isColliding = true;
    }
    void OnTriggerExit2D()
    {
        isColliding = false;
        textBox.displayText("");
    }

}
