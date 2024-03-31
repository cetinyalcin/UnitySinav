using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NesneEkle : MonoBehaviour
{
    // Start is called before the first frame 
    [SerializeField]
    private GameObject[] nesneler;
    void Start()
    {

         aynıCizgideNesne(new Vector3(21,4,5),new Vector3(288,4,5),new Vector3(21,0,0),nesneler[0]);
         aynıCizgideNesne(new Vector3(21,4,25),new Vector3(288,4,25),new Vector3(21,0,0),nesneler[0]);
    }

    private void rastGeleNesneEkle()
    {


    }
    private void ayniCizgideNesneEkle(float x, float y, float z, float ikiNesneArasiMesafe, float nesneGenislik, float maxUzaklik, int deksen, GameObject nesne)
    {
        GameObject yeniNesne = (GameObject)PrefabUtility.InstantiatePrefab(nesne);
        yeniNesne.transform.position = new Vector3(x, y, z);
        yeniNesne.transform.rotation = Quaternion.identity;

    }
    private void aynıCizgideNesne(Vector3 baslangic, Vector3 bitis, Vector3 mesafe, GameObject nesne)
    {
        Vector3 temp = baslangic;
        while (temp.magnitude < bitis.magnitude)
        {
            GameObject yeniNesne = (GameObject)PrefabUtility.InstantiatePrefab(nesne);
            yeniNesne.transform.position = temp;
            yeniNesne.transform.rotation = Quaternion.identity;
            temp += mesafe;

        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
