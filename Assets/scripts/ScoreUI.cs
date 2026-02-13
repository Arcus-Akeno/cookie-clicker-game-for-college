using UnityEngine;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private TMP_Text ScoreText;


    private void Awake()
    {
        ScoreText = GetComponent<TMP_Text>();
    }


    
    
    
    public void UpdateScore(ScoreViaButton ScoreViaButton)
    {
        ScoreText.text = $"Score:{ScoreViaButton.Score}";
    }
}
