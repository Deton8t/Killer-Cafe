using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class safeScript : MonoBehaviour
{
    public string lookAtText;
    public bool isColliding;
    public KeyCode interact;
    public KeyCode lookAt;
    public TextHandler textBox;
    public GameObject safe;
    public string safeCode;




    // Start is called before the first frame update
    void Start()
    {
        interact = KeyCode.E;
        lookAt = KeyCode.F;
        safe.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isColliding)
        {
            if (Input.GetKeyDown(interact))
            {
                safe.SetActive(true);
            }
            else if (Input.GetKeyDown(lookAt))
            {
                textBox.displayText(lookAtText);
                Debug.Log("Viewed");
            }

        }

        if (safe.activeSelf && safe.GetComponent<TMP_InputField>().text == safeCode)
        {
            SceneManager.LoadScene("CutScene5");
            safe.SetActive(false);
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
        safe.SetActive(false);
    }


}
