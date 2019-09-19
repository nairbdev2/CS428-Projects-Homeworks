using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB_Script : MonoBehaviour, IVirtualButtonEventHandler 
{
    public GameObject vbBtnObj;
    public GameObject spokePerson;

    //Counter To Toggle 'On' or 'Off'
    bool buttonToggle;


    // Start is called before the first frame update
    void Start()
    {

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        buttonToggle = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {

        string virButton = vb.ToString();
        string[] stringSplit = virButton.Split(' ');

        if (stringSplit[0].Equals("VB_Start_Button"))
        {
            if (buttonToggle == false)
            {
                buttonToggle = true;
                spokePerson.SetActive(true);
            } else
            {
                buttonToggle = false;
                spokePerson.SetActive(false);
            }
        }
        Debug.Log("Button Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {

        Debug.Log("Button Released");
    }


}
