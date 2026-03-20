using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class clicker : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public int Gem;
    public GameObject GemCounter;
    public int Upgrade;
    public GameObject HowManyPickaxes;
    public void click() 
   {
        Gem +=1;
        text.text = Gem.ToString();

        GemCounter.GetComponent<SHOP>().GemUpdate(Gem);

        HowManyPickaxes.GetComponent<SHOP>().UpgradeUpdate(Upgrade);
        Gem +=1 + Upgrade;

   }
}
