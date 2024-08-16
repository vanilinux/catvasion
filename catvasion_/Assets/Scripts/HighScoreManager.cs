using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _count;

    private int count;
    void Start()
    {
        count = PlayerPrefs.GetInt("count_key", 0);
        _count.text = count.ToString();
    }
}
