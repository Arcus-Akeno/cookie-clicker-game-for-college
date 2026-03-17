using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class SHOP : MonoBehaviour
{
   
    public int Gem;
    public TMPro.TextMeshProUGUI  Gem_text;
    public int Upgrade;
    public int Upgrade_text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Gem_text.text = Gem.ToString();
    }
    public void BuyUpgrade()
    {
        if (Gem >= 20)
        {
            Gem -= 20;
            Gem_text.text = Gem.ToString();

            //Upgrade
        }
        else
        {
            print("Not Enough Gems");
        }
    }
    
    public void GemUpdate(int CurrentGems)
    {
        Gem = CurrentGems;

        Gem_text.text = CurrentGems.ToString();
    }
}
