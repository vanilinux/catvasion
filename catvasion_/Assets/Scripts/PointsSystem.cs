using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _score_text;
    private static int score;

    void Start()
    {
        score = 0;
    }

    public void Score(int _score)
    {
        score += _score;
        if (score < 0)
        {
            score = 0;
        }
        _score_text.text = score.ToString();

    }
}
