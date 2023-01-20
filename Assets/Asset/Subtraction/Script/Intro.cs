using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameObject[] GA_Text;
    public int I_Qcount;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<GA_Text.Length;i++)
        {
            GA_Text[i].SetActive(false);
        }
        GA_Text[I_Qcount].SetActive(true);
    }

    public void BUT_Next()
    {
        if(I_Qcount<GA_Text.Length-1)
        {
            I_Qcount++;
            GA_Text[I_Qcount].SetActive(true);
        }
        
    }
}
