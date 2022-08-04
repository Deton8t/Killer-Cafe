using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DoorCodeWithItem : MonoBehaviour
{
    public string lookAtText;
    public bool isColliding;
    public KeyCode interact;
    public KeyCode lookAt;
    public TextHandler textBox;
    public int interactCount;
    public string noKnifeText;




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
            if (itemTracker.baristaDead)
            {
                if (Input.GetKeyDown(interact))
                {
                    //make if statement for knife
                    SceneManager.LoadScene("CultRoom");
                }


            }
            else
            {
                if (Input.GetKeyDown(interact) && itemTracker.hasItem1 && interactCount > 0)
                {
                    //make if statement for knife
                    SceneManager.LoadScene("CutScene3");
                }
                else if (Input.GetKeyDown(interact) && itemTracker.hasItem1 == false)
                {
                    textBox.displayText("The barista had a knife. I dont wanna go in without my own.");
                }
                if (Input.GetKeyDown(interact) && itemTracker.hasItem1 && interactCount == 0)
                {
                    textBox.displayText("Are you sure? Interact again to confirm.");
                    interactCount += 1;
                }
                if (Input.GetKeyDown(lookAt))
                {
                    textBox.displayText(lookAtText);
                    Debug.Log("Viewed");
                }

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
