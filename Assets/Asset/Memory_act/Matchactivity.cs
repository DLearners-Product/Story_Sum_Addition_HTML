using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Matchactivity : MonoBehaviour
{
    GameObject G_Selected1, G_Selected2;
    int I_Qcount, I_Dummy;
    public AudioSource AS_Correct, AS_Wrong, AS_Click;
    bool B_CanClick;
    // Start is called before the first frame update
    void Start()
    {
        I_Dummy = I_Qcount = 0;
        B_CanClick = true;
        
    }

    public void BUT_Clicking()
    {
        if(B_CanClick)
        {
            I_Dummy++;
            AS_Click.Play();
            if (I_Dummy%2!=0)
            {
                G_Selected1 = EventSystem.current.currentSelectedGameObject;
                G_Selected1.GetComponent<Animator>().Play("memorycard");
            }
            else
            {
                B_CanClick = false;
                G_Selected2 = EventSystem.current.currentSelectedGameObject;
                G_Selected2.GetComponent<Animator>().Play("memorycard");
                Invoke("THI_Check", 2f);
            }
        }
    }

    public void THI_Check()
    {
        if(G_Selected1.name==G_Selected2.name)
        {
            AS_Correct.Play();
            B_CanClick = true;
            G_Selected1.GetComponent<Button>().enabled = false;
            G_Selected2.GetComponent<Button>().enabled = false;
        }
        else
        {
            AS_Wrong.Play();
            G_Selected1.GetComponent<Animator>().Play("reverse");
            G_Selected2.GetComponent<Animator>().Play("reverse");
            
            I_Qcount++;
            B_CanClick = true;
        }
    }
}
