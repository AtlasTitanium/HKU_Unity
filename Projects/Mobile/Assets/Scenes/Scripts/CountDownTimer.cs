using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{

    public float totalTime;
    public AudioSource beep;
    public int lowSuspence = 15;
    public int highSuspence = 5;
    private Color32 orangeColor = new Color32 (255, 128, 0, 255);
    private Color redColor = Color.red;
    int waitTime = 1;
    bool keepPlaying = true;

    private void Start()
    {
        StartCoroutine(SoundOut());
        beep.volume = 0.05f;
    }

    IEnumerator SoundOut()
    {
        while (keepPlaying)
        {
            beep.Play();
            yield return new WaitForSeconds(waitTime);
        }
    }

    private void Update()
    {
        totalTime -= Time.deltaTime;
        UpdateLevelTimer(totalTime);
    }



    public void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);
        PlayerScript userHeadline = GameObject.Find("PlayerInput").GetComponent<PlayerScript>();
        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }
        Text timer = GameObject.Find("Timer").GetComponent<Text>();
        timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");

        if (seconds == 0 && minutes == 0)
        {
            SceneManager.LoadScene("VotingRound");
            Destroy(gameObject);
            if (userHeadline.userHeadline == "INVULLEN" || userHeadline.userHeadline == "")
            {
                userHeadline.userHeadline = "";
            }
        }
        if (seconds <= lowSuspence && minutes == 0)
        {
            timer.color = orangeColor;
            beep.volume = 0.1f;
        }

        if (seconds <= highSuspence && minutes == 0)
        {
            timer.color = redColor;
            beep.volume = 0.15f;
        }
    }
}

