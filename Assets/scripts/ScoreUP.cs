using UnityEngine;
using UnityEngine.Events;
public class ScoreUP : MonoBehaviour
{
    public UnityEvent OnScoreChanged;
    public int Score { get; private set; }

    public void addscore(int amount)
    {
        Score += amount;
        OnScoreChanged.Invoke();
    }

   
}
