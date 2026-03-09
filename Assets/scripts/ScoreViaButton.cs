using UnityEngine;

public class ScoreViaButton : MonoBehaviour
{
    [SerializeField]
    public int _ButtonScore;

    public ScoreUP ScoreUP;
   

    private void Awake()
    {
        ScoreUP = FindAnyObjectByType<ScoreUP>();

    }

    public void AllocateScore()
    {
        ScoreUP.addscore(_ButtonScore);
    }



}
