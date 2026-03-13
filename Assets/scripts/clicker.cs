using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class clicker : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void click() 
   {
        count += 1;
        text.text = count.ToString();
    
   }
}
