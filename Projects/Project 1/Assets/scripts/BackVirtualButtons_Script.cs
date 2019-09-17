using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BackVirtualButtons_Script : MonoBehaviour, IVirtualButtonEventHandler
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;

    //Variables
    public GameObject Map_GroupObj;
    public GameObject BookReview_GroupObj;
    public GameObject VideoReview_GroupObj;
    public GameObject Text_GroupObj;

    //VideoObjects
    public GameObject bdevil2Video;
    public GameObject nhe3Video;
    public GameObject yli265Video;

    //BookObjects
    public GameObject bdevil2Book;
    public GameObject nhe3Book;
    public GameObject yli265Book;

    //Counter when to Cycle through
    int BookCycleCounter;
    int VideoCycleCounter;


    // Start is called before the first frame update
    void Start()
    {
        //Register all the buttons
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
        {
            virtualButtonBehaviours[i].RegisterEventHandler(this);
        }

        //Cyclec Counter
        BookCycleCounter = 0;
        VideoCycleCounter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        string virButton = vb.ToString();
        string[] stringSplit = virButton.Split(' ');

        if (stringSplit[0].Equals("BookReviewButton"))
        {
            Map_GroupObj.SetActive(false);
            BookReview_GroupObj.SetActive(true);
            Text_GroupObj.SetActive(false);
            VideoReview_GroupObj.SetActive(false);

            //Implement cycling through the Book Reviews 
            if (BookCycleCounter == 1)
            {
                bdevil2Book.SetActive(true);
                yli265Book.SetActive(false);
                nhe3Book.SetActive(false);
            }
            else if (BookCycleCounter == 2)
            {
                bdevil2Book.SetActive(false);
                yli265Book.SetActive(true);
                nhe3Book.SetActive(false);
            }
            else if (BookCycleCounter == 3)
            {
                bdevil2Book.SetActive(false);
                yli265Book.SetActive(false);
                nhe3Book.SetActive(true);
            }
            else
            {
                BookCycleCounter = 0;
            }

            BookCycleCounter++;



            Debug.Log("BookReviewButton was pressed.");
        }
        else if (stringSplit[0].Equals("VideoReviewButton"))
        {
            Map_GroupObj.SetActive(false);
            BookReview_GroupObj.SetActive(false);
            Text_GroupObj.SetActive(false);
            VideoReview_GroupObj.SetActive(true);

            //Implement Cycling through the videos
            if (VideoCycleCounter == 1)
            {
                bdevil2Video.SetActive(true);
                yli265Video.SetActive(false);
                nhe3Video.SetActive(false);
            } else if (VideoCycleCounter == 2)
            {
                bdevil2Video.SetActive(false);
                yli265Video.SetActive(true);
                nhe3Video.SetActive(false);
            } else if (VideoCycleCounter == 3)
            {
                bdevil2Video.SetActive(false);
                yli265Video.SetActive(false);
                nhe3Video.SetActive(true);
            } else
            {
                VideoCycleCounter = 0;
            }
            
            VideoCycleCounter++;

            Debug.Log("VideoReviewButton was pressed.");
        }
        else if (stringSplit[0].Equals("ShowMapButton"))
        {
            Map_GroupObj.SetActive(true);
            BookReview_GroupObj.SetActive(false);
            Text_GroupObj.SetActive(false);
            VideoReview_GroupObj.SetActive(false);
            Debug.Log("MapButton was pressed.");
        } else
        {
            Debug.Log("Nothing was read in.");
        }
        
        Debug.Log("Button Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
        Debug.Log("Button Released");
    }


}
