using UnityEngine;

public class MinerClicker : MonoBehaviour
{

    public TMPro.TextMeshProUGUI text;
    public int Gem;
    public GameObject GemCounter;


    public void click()
    {
        Gem += 10;
        text.text = Gem.ToString();

        GemCounter.GetComponent<SHOP>().GemUpdate(Gem);


    }
}
