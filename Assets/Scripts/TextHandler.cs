using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    public Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        textBox = this.GetComponent<Text>();
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void displayText(string objectText)
    {
        textBox.text = objectText;
        Debug.Log("text has been changed");
    }
}
