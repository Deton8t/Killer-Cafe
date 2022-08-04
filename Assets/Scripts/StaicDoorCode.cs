using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaicDoorCode : MonoBehaviour
{
    public string lookAtText;
    public bool isColliding;
    public KeyCode interact;
    public KeyCode lookAt;
    public TextHandler textBox;
    public bool room1;
    public string scene;


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
                itemTracker.fromRoom1 = room1;
                SceneManager.LoadScene(scene);
            }
            else if (Input.GetKeyDown(lookAt))
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
    }

}
