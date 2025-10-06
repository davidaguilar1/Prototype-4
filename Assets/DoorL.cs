using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class DoorL : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Death");
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
