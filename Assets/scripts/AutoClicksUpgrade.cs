using UnityEngine;

public class AutoClicksUpgrade : MonoBehaviour
{
    bool hasUpgrade;
    public int Gem;
    public TMPro.TextMeshProUGUI Gem_text;
    public int AutoClicksPerSecond;
    public int AutoClickUpgrade;
    public TMPro.TextMeshProUGUI AutoClickUpgrade_text;
    private void Update()
    {
        hasUpgrade = true;
       Gem += (int)(AutoClicksPerSecond * Time.deltaTime);

        Gem_text.text = Gem.ToString("0");
    }
}
