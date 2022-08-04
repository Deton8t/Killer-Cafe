using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatInteraction : MonoBehaviour
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
            if (itemTracker.hasItem1)
            {
                textBox.displayText("You found a knife in the center of the meat");
            }
            else
            {
                if (Input.GetKeyDown(interact) && interactCount > 1)
                {
                    textBox.displayText("You found a knife in the center of the meat");
                    itemTracker.hasItem1 = true;
                    spawner.loadItem();
                    interactCount += 1;

                }
                if (Input.GetKeyDown(interact) && interactCount == 1)
                {
                    textBox.displayText("You dig through once more and feel something in the center");
                    interactCount += 1;
                }
                if (Input.GetKeyDown(interact) && interactCount == 0)
                {
                    textBox.displayText("You dig through the meat and find nothing");
                    Debug.Log("yeah");
                    interactCount += 1;
                }

                if (Input.GetKeyDown(lookAt))
                {
                    textBox.displayText(lookAtText);
                    Debug.Log("Viewed");
                }
                else
                {

                }
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


