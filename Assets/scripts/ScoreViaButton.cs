using UnityEngine;

public class ScoreViaButton : MonoBehaviour
{
    [SerializeField]
    private int _ButtonScore;

    private ScoreUP ScoreUP;
   

    private void Awake()
    {
        ScoreUP = FindAnyObjectByType<ScoreUP>();

    }

    public void AllocateScore()
    {
        ScoreUP.addscore(_ButtonScore);
    }



}
