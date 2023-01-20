using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class quickmath : MonoBehaviour
{
    public GameObject[] GA_Que;
    public int I_Qcount;
    public AudioSource AS_Wrg, AS_Crt;
    // Start is called before the first frame update
    void Start()
    {
        I_Qcount = 0;
        THI_Show();
    }

    public void THI_Show()
    {
        for(int i=0;i<GA_Que.Length;i++)
        {
            GA_Que[i].SetActive(false);
        }
        GA_Que[I_Qcount].SetActive(true);
    }
   public void BUT_Next()
    {
        if(I_Qcount<GA_Que.Length-1)
        {
            I_Qcount++;
            THI_Show();
        }
    }

    public void BUT_Check()
    {
        GameObject G_Selected = EventSystem.current.currentSelectedGameObject.transform.parent.GetChild(0).gameObject;

        if (G_Selected.name == G_Selected.GetComponent<InputField>().text)
        {
            AS_Crt.Play();
            G_Selected.GetComponent<InputField>().interactable = false;
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>().enabled = false;
        }
        else
        {
            AS_Wrg.Play();
        }
    }
}
