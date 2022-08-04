using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCodeWIthItem2 : MonoBehaviour
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
            if (Input.GetKeyDown(interact) && itemTracker.hasItem2 == false)
            {
                textBox.displayText("I need a key");
            }
            else
            {
                if (Input.GetKeyDown(interact) && itemTracker.hasItem2 && interactCount != 0)
                {
                    SceneManager.LoadScene("MainRoom2");
                }
                if (Input.GetKeyDown(interact) && itemTracker.hasItem2 && interactCount == 0)
                {
                    textBox.displayText("Are you sure? Interact again to confirm.");
                    interactCount += 1;
                }
            }
            if (Input.GetKeyDown(lookAt))
            {
                textBox.displayText(lookAtText);
                Debug.Log("Viewed");
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
