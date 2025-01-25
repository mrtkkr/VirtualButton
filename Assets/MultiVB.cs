using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MultiVB : MonoBehaviour
{
    public GameObject dance, kos, poz;
    VirtualButtonBehaviour[] vrb;
    // Start is called before the first frame update
    void Start()
    {
        dance.SetActive(false);
        kos.SetActive(false);
        poz.SetActive(true);

        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterOnButtonPressed(onButtonPressed);
            vrb[i].RegisterOnButtonReleased(onButtonReleased);

        }


    }


    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "kos")
        {
            poz.SetActive(false);
            kos.SetActive(true);
            dance.SetActive(false);
            Debug.Log("Butona Basýldý");
        }
        else if (vb.VirtualButtonName == "danset")
        {
            poz.SetActive(false);
            kos.SetActive(false);
            dance.SetActive(true);
            Debug.Log("Butona Basýldý");
        }

        else
        {
            Debug.Log("Desteklenmiyor");
        }


    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        dance.SetActive(false);
        kos.SetActive(false);
        poz.SetActive(true);
        Debug.Log("Butona basýlmadý");

    }

}
