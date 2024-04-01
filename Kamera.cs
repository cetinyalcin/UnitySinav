using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    [SerializeField]
    Camera[] kameralar;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            kameralar[0].enabled = true;
            kameralar[1].enabled = false;
            kameralar[2].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            kameralar[0].enabled = false;
            kameralar[1].enabled = true;
            kameralar[2].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            kameralar[0].enabled = false;
            kameralar[1].enabled = false;
            kameralar[2].enabled = true;
        }
    }
}
