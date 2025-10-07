using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI timerText;
    public Slider timerBar; // Assign a UI Slider in the Inspector
    public AudioSource audioSource; // Assign an AudioSource in the Inspector
    public float duration = 20f; // Duration of the timer in seconds

    private float timeRemaining;

    void Start()
    {
        timeRemaining = duration;
        timerBar.maxValue = duration;
        timerBar.value = duration;
        audioSource.Play(); // Start playing the audio
    }

    void Update()
    {
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
            }
        }
    }
}
