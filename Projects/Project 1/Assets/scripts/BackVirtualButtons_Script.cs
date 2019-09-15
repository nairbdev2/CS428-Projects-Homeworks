using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BackVirtualButtons_Script : MonoBehaviour, IVirtualButtonEventHandler
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;

    //Variables
    string virButton;
    //Three Buttons
    public GameObject BookReviewButton;
    public GameObject VideoReviewButton;
    public GameObject MapButton;

    //Three Objects to Hide
    public GameObject Map_GroupObj;
    


    // Start is called before the first frame update
    void Start()
    {
        //Register all the buttons
        //virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        //for (int i = 0; i < virtualButtonBehaviours.Length; i++)
        //{
        //    virtualButtonBehaviours[i].RegisterEventHandler(this);
        //}

        BookReviewButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        VideoReviewButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        MapButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        virButton = vb.VirtualButtonName;

        if (virButton.Equals("BookReviewButton"))
        {
            Map_GroupObj.SetActive(false);
            Debug.Log("BookReviewButton was pressed.");
        }
        else if (virButton.Equals("VideoReviewButton"))
        {
            Map_GroupObj.SetActive(false);
            Debug.Log("VideoReviewButton was pressed.");
        }
        else if (virButton.Equals("MapButton"))
        {
            Map_GroupObj.SetActive(true);
            Debug.Log("MapButton was pressed.");
        } else
        {

        }
        

        Debug.Log("Button Pressed");
        Debug.Log("What is this: " + virButton);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
        Debug.Log("Button Released");
    }


}
