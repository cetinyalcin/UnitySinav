using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Start");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene("DersAnlat");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("Test");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("TestOne");
        }
    }
}
