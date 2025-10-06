using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class DoorR : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Level2");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
