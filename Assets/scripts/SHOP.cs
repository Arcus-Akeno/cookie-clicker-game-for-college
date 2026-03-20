using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;


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
    public int Miner;
    public TMPro.TextMeshProUGUI Miner_text;
    [Header("Delay")]
    public float AutoClickerDelaytime;
    public bool IsDelayed = false;

    [Header("Emploies")]
    public bool employieUnlocked;
    public int employees = 0;
    public bool employeeWorkable = true;
    public bool ManagerUnlock;
    public bool Managering;

    public GameObject Emplie_Button;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Gem = PlayerPrefs.GetInt("Gem");
        Upgrade = PlayerPrefs.GetInt("Upgrade");
        Gem_text.text = Gem.ToString();
        Upgrade_text.text = Upgrade.ToString();
        AutoClickUpgrade_text.text = AutoClickUpgrade.ToString();
        AutoClickUpgrade = PlayerPrefs.GetInt("AutoClickUpgrade");
        Miner_text.text = Miner.ToString();
        Miner = PlayerPrefs.GetInt("Miner");
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
        Debug.Log("clicked");

        if (Gem >= 20)
        {
            Gem -= 20;
            Gem_text.text = Gem.ToString();

            AutoClickUpgrade += 1;
            AutoClickUpgrade_text.text = AutoClickUpgrade.ToString();
            hasUpgrade = true;
            PlayerPrefs.SetInt("Gem", Gem);
            PlayerPrefs.SetInt("AutoClickUpgrade", AutoClickUpgrade);

        }
        else
        {
            print("Not Enough Gems");
        }
    }

    public void BuyMiner()
    {
        if (Gem >= 20)
        {
            Gem -= 20;
            Gem_text.text = Gem.ToString();

            Miner += 1;
            Miner_text.text = Miner.ToString();
            PlayerPrefs.SetInt("Gem", Gem);
            PlayerPrefs.SetInt("Miner", Miner);

        }
        else
        {
            print("Not Enough Gems");
        }
    }

    public void EmployEmplie()
    {
        if(Gem >= 20)
        {
            Gem -= 20;
            Gem_text.text = Gem.ToString();

            employieUnlocked = true;
            employees++;
            Emplie_Button.gameObject.SetActive(true);
        }
    }

    public void EmplieWork()
    {
        Debug.Log(employeeWorkable);

        if (employeeWorkable)
        {
            if (!ManagerUnlock)
            {
                Emplie_Button.SetActive(false);
            }

            StartCoroutine(EmplieRest());
        }
    }


    public void EmployManager()
    {
        if (Gem >= 100)
        {
            Gem -= 100;
            Gem_text.text = Gem.ToString();

            Emplie_Button.SetActive(false);

            ManagerUnlock = true;
            Managering = true;
        }
    }

    private void Update()
    {
        if (hasUpgrade)
        {
            if (!IsDelayed)
            {
                StartCoroutine(AutoclickDelay());
                IsDelayed = true;
            }
        }
        if (Managering && employeeWorkable)
        {
            StartCoroutine(EmplieRest());
        }
    }
    public void GemUpdate(int CurrentGems)
    {
        Gem = CurrentGems;

        Gem_text.text = CurrentGems.ToString();
    }
    public void UpgradeUpdate(int Upgrades)
    {
        Upgrade = Upgrades;

        Upgrade_text.text = Upgrades.ToString();
    }

    IEnumerator AutoclickDelay()
    {
        Debug.Log("AutoStart");
        yield return new WaitForSeconds(AutoClickerDelaytime);
        Gem += AutoClicksPerSecond;
        Gem_text.text = Gem.ToString("0");
        IsDelayed = false;

        Debug.Log("AutoEnd");
    }

    IEnumerator EmplieRest()
    {
        Gem += 10 * employees;
        Gem_text.text = Gem.ToString();
        employeeWorkable = false;

        yield return new WaitForSeconds(8);

        employeeWorkable = true;

        if (!ManagerUnlock)
        {
            Emplie_Button.SetActive(true);
        }
    }
}
