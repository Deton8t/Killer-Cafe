using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MopScript : MonoBehaviour
{
    public string lookAtText;
    public bool isColliding;
    public KeyCode interact;
    public KeyCode lookAt;
    public TextHandler textBox;
    public itemSpawner items;
    public MopCover mopCover;





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
                textBox.displayText("You picked up the mop");
                itemTracker.hasItem3 = true;
                items.loadItem();
                mopCover.load();

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
    }
}
