using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public TMPro.TextMeshProUGUI timerText;
    public Slider timerBar;
    public AudioSource audioSource;
    public float duration = 20f;

    private float timeRemaining;

    void Start()
    {
       
        timeRemaining = duration;
        timerBar.maxValue = duration;
        timerBar.value = duration;
        audioSource.Play(); 
    }

    void Update()
    {
        if (timeRemaining <= 12)
        {

        }
            if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerBar.value = timeRemaining;

            if (timerText != null)
            {
                timerText.text = "Time left: " + Mathf.Ceil(timeRemaining).ToString();
            }
            

            if (timeRemaining <= 0)
            {
                audioSource.Stop();
                if (timerText != null)
                {
                    timerText.text = "Time left: 0";
                }
                SceneManager.LoadScene("Death");
            }
        }
    }
}
