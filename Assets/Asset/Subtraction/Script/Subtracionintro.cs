using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Subtracionintro : MonoBehaviour
{
    public GameObject[] GA_Text;
    public GameObject[] GA_Question;
    public int I_Qcount,I_Count;
    public AudioSource AS_Wrg, AS_Crt;
    public GameObject G_Next;
    // Start is called before the first frame update
    void Start()
    {
        I_Count = I_Qcount = 0;
        for (int i = 0; i < GA_Text.Length; i++)
        {
            GA_Text[i].SetActive(false);
        }
        GA_Text[I_Qcount].SetActive(true);
        for (int i = 0; i < GA_Question.Length; i++)
        {
            GA_Question[i].SetActive(false);
        }
        GA_Question[0].SetActive(true);
    }

    public void BUT_Next()
    {
        if (I_Qcount < GA_Text.Length - 1)
        {
            G_Next.GetComponent<Button>().interactable = true;
            I_Qcount++;
            GA_Text[I_Qcount].SetActive(true);
            if (this.name == "5intro_addition(Clone)")
            {
                THI_Question();
            }
            else
            {
                THI_Activity();
            }
        }
        else
        {
            G_Next.GetComponent<Button>().interactable = false;
        }

    }
    public void THI_Activity()
    {
        if (I_Qcount == 1 || I_Qcount == 2)
        {
            for (int i = 0; i < GA_Question.Length; i++)
            {
                GA_Question[i].SetActive(false);
            }
            GA_Question[I_Qcount].SetActive(true);
        }
        else
        {
            for (int i = 0; i < GA_Question.Length; i++)
            {
                GA_Question[i].SetActive(false);
            }
            GA_Question[0].SetActive(true);
        }
    }
    public void THI_Question()
    {
        if (I_Qcount != 3 && I_Qcount != 1)
        {
            int count = 0;
            for (int i = 0; i < GA_Question.Length; i++)
            {
                GA_Question[i].SetActive(false);
            }
            GA_Question[count].SetActive(true);
        }
        if (I_Qcount == 3)
        {
            int count = I_Qcount - 1;
            for (int i = 0; i < GA_Question.Length; i++)
            {
                GA_Question[i].SetActive(false);
            }
            GA_Question[count].SetActive(true);
        }

        if (I_Qcount == 1)
        {
            for (int i = 0; i < GA_Question.Length; i++)
            {
                GA_Question[i].SetActive(false);
            }
            GA_Question[I_Qcount].SetActive(true);
        }
    }
    public void BUT_Check()
    {
        GameObject G_Selected = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
       
        for (int i=0;i<G_Selected.transform.childCount-1;i++)
        {
          
            if (G_Selected.transform.GetChild(i).name == G_Selected.transform.GetChild(i).GetComponent<InputField>().text)
            {
                I_Count++;
                if (I_Count == 2)
                {
                    AS_Crt.Play();
                   
                    /*for (int k = 0; k < G_Selected.transform.childCount - 1; k++)
                    {
                        G_Selected.transform.GetChild(k).
                    }*/
                }
            }
            else
            {
                AS_Wrg.Play();
            }
        }
        
    }
}
