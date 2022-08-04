using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpillScript : MonoBehaviour
{
    public string lookAtText;
    public bool isColliding;
    public KeyCode interact;
    public KeyCode lookAt;
    public TextHandler textBox;
    public itemSpawner items;
    public MopCover mopCover;
    public int interactCount;





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
            if (itemTracker.hasItem3)
            {
                if (Input.GetKeyDown(interact))
                {
                    if (interactCount == 1)
                    {
                        SceneManager.LoadScene("Cutscene4");
                        itemTracker.mopped = true;
                    }
                }
                if (Input.GetKeyDown(interact) && interactCount == 0)
                {
                    textBox.displayText("Do you want to mop this?");
                    interactCount += 1;
                }
            }
            else
            {
                if (Input.GetKeyDown(interact) && itemTracker.mopped == false)
                {
                    textBox.displayText("I'm not a fan of this spill");
                }
                else if (Input.GetKeyDown(interact) && itemTracker.mopped)
                {
                    textBox.displayText("181? What could that mean?");
                }
            }
            if (Input.GetKeyDown(lookAt))
            {
                textBox.displayText("It's a suspicious spill");
            }
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
        interactCount = 0;
    }
}
