using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{
    public float timeLeft;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = itemTracker.timeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            gameOver();
        }
        float minutes = timeLeft / 60F;
        float seconds = timeLeft % 60F;
        minutes = minutes - seconds / 60F;
        string timerMinute = minutes.ToString();
        string timerSeconds = seconds.ToString("F5");
        if (timerSeconds.Length == 8)
        {
            timerSeconds = timerSeconds.Remove(2, 6);
        }
        if (timerSeconds.Length == 7)
        {
            timerSeconds = timerSeconds.Remove(1, 6);
            timerSeconds = "0" + timerSeconds;
        }
        if (timerSeconds.Length == 6)
        {
            timerSeconds = "00";
        }
        string timerBoth = timerMinute + ":" + timerSeconds;
        timerText.text = timerBoth;
        saveTime();

    }
    public void saveTime()
    {
        itemTracker.timeLeft = timeLeft;
    }
    public void gameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
