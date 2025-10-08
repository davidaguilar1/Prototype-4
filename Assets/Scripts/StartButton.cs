using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {

            audioSource.Play();
            StartCoroutine(WaitAndLoadNextScene());

        }
    }

    private System.Collections.IEnumerator WaitAndLoadNextScene()
    {

        yield return new WaitForSeconds(audioSource.clip.length);

        // Load the next scene (by build index)
        SceneManager.LoadScene("SampleScene"); 
            }
}
