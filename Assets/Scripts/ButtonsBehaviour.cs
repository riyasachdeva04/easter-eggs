using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonsBehaviour : MonoBehaviour
{

    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;

    VirtualButtonBehaviour VirtualButton1;
    VirtualButtonBehaviour VirtualButton2;
    VirtualButtonBehaviour VirtualButton3;
    VirtualButtonBehaviour VirtualButton4;

   
    // Start is called before the first frame update
    void Start()
    {
        // initially set all false
        sphere1.SetActive(false);
        sphere2.SetActive(false);
        sphere3.SetActive(false);
        sphere4.SetActive(false);

        // virtual button components
        VirtualButton1 = transform.Find("VirtualButton1").GetComponent<VirtualButtonBehaviour>();
        VirtualButton2 = transform.Find("VirtualButton2").GetComponent<VirtualButtonBehaviour>();
        VirtualButton3 = transform.Find("VirtualButton3").GetComponent<VirtualButtonBehaviour>();
        VirtualButton4 = transform.Find("VirtualButton4").GetComponent<VirtualButtonBehaviour>();

        // Register button event handlers
        VirtualButton1.RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton1.RegisterOnButtonReleased(OnButtonReleased);

        VirtualButton2.RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton2.RegisterOnButtonReleased(OnButtonReleased);

        VirtualButton3.RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton3.RegisterOnButtonReleased(OnButtonReleased);

        VirtualButton4.RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton4.RegisterOnButtonReleased(OnButtonReleased);

    }

    void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "VirtualButton1")
        {
            sphere1.SetActive(true);

        }

        else if(vb.VirtualButtonName == "VirtualButton2")
        {
            sphere2.SetActive(true);

        }       

        else if(vb.VirtualButtonName == "VirtualButton3")
        {
            sphere3.SetActive(true);

        }   

        else if(vb.VirtualButtonName == "VirtualButton4")
        {
            sphere4.SetActive(true);

        }
    
    }

    void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        sphere1.SetActive(false);
        sphere2.SetActive(false);
        sphere3.SetActive(false);
        sphere4.SetActive(false);
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
