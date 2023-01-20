using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity1 : MonoBehaviour
{
    public GameObject[] GA_Objects;
    public int I_count,I_dummy;
    public GameObject G_final;

    // Start is called before the first frame update
    void Start()
    {
        I_count = 0;
        G_final.SetActive(false);
        showquestion();
    }
    public void showquestion()
    {
        for (int i = 0; i < GA_Objects.Length; i++)
        {
            GA_Objects[i].SetActive(false);
        }
        GA_Objects[I_count].SetActive(true);
    }
    
    public void BUT_cardflip()
    {
        I_dummy++;
        if (I_dummy % 2 != 0)
        {
            GA_Objects[I_count].transform.GetChild(0).GetComponent<Animator>().Play("cardflip1");
        }
        else
        {
            GA_Objects[I_count].transform.GetChild(0).GetComponent<Animator>().Play("reverseflip");
        }
    }
    public void BUT_next()
    {
        I_count++;
        if(I_count<GA_Objects.Length)
        {
            showquestion();
        }
        else
        {
            G_final.SetActive(true);
        }
    }
    public void BUT_Back()
    {
        I_count--;
        if (I_count > -1)
        {
            showquestion();
        }
        else
        {
            G_final.SetActive(true);
        }

    }
}
