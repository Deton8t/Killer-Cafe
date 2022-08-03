using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch1 : MonoBehaviour
{
    public string sceneToGoTo;
    public int delaySeconds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NowDelay(delaySeconds));
        
    }

    IEnumerator NowDelay(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneToGoTo);   
    }
    
}
