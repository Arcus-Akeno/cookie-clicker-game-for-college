using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class SHOP : MonoBehaviour
{
   
    public int Gem;
    public TMPro.TextMeshProUGUI  Gem_text;
    public int Upgrade;
    public TMPro.TextMeshProUGUI Upgrade_text;
    bool hasUpgrade;
    public int AutoClicksPerSecond;
    public int AutoClickUpgrade;
    public TMPro.TextMeshProUGUI AutoClickUpgrade_text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Gem = PlayerPrefs.GetInt("Gem");
        Upgrade = PlayerPrefs.GetInt("Upgrade");
        Gem_text.text = Gem.ToString();
        Upgrade_text.text = Upgrade.ToString();
        AutoClickUpgrade_text.text = AutoClickUpgrade.ToString();
        AutoClickUpgrade = PlayerPrefs.GetInt("AutoClickUpgrade");
    }
    public void BuyUpgrade()
    {
        if (Gem >= 20)
        {
            Gem -= 20;
            Gem_text.text = Gem.ToString();

            Upgrade += 1;
            Upgrade_text.text = Upgrade.ToString();
            PlayerPrefs.SetInt("Gem", Gem);
            PlayerPrefs.SetInt("Upgrade", Upgrade);
        }
        else
        {
            print("Not Enough Gems");
        }
    }
    public void BuyAutoClickUpgrade()
    {
        if (Gem >= 20)
        {
            Gem -= 20;
            Gem_text.text = Gem.ToString();

            AutoClickUpgrade += 1;
            AutoClickUpgrade_text.text = AutoClickUpgrade.ToString();
            PlayerPrefs.SetInt("Gem", Gem);
            PlayerPrefs.SetInt("AutoClickUpgrade", AutoClickUpgrade);
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
