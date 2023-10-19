using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Dynamic")]
    public int score = 0;
    private TextMeshProUGUI uiText;
    void Start()
    {
        uiText =GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = "Score: " + score.ToString("#,0");
    }

    public void IncreaseScore()
    {
        score += 100;
        HighScore.TRY_SET_HIGH_SCORE(score);
    }
    

}
