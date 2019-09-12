using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB_Script : MonoBehaviour, IVirtualButtonEventHandler 
{
    public GameObject vbBtnObj;
    public GameObject spokePerson;


    // Start is called before the first frame update
    void Start()
    {

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        spokePerson.SetActive(true);
        Debug.Log("Button Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        spokePerson.SetActive(false);
        Debug.Log("Button Released");
    }


}
