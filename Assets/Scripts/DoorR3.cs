using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class DoorR3 : MonoBehaviour
{
    public GameObject Light;

    public void OnMouseDown()
    {
        SceneManager.LoadScene("Win");
    }
    public void OnMouseOver()
    {
        Light.SetActive(true);



    }
    public void OnMouseExit()
    {
        Light.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Light.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
