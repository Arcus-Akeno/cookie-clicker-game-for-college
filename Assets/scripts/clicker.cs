using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class clicker : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public int Gem;
    public GameObject GemCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void click() 
   {
        Gem += 1;
        text.text = Gem.ToString();

        GemCounter.GetComponent<SHOP>().GemUpdate(Gem);


   }
}
