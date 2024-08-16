using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] public float _time = 45f;
    [SerializeField] public TextMeshProUGUI _time_text;
    [SerializeField] public TextMeshProUGUI _title;
    [SerializeField] public TextMeshProUGUI _count;
    //[SerializeField] public TextMeshProUGUI _score;

    public int max = 0;
    public int min = 0;

    private float game_time;

    private int count = 0;

    private GameObject canvas;


    //[SerializeField] AudioSource losingSound;
    //[SerializeField] AudioSource winningSound;

    private void Start()
    {
        canvas = GameObject.Find("GameOver");
        canvas.SetActive(false);
    }

    void Update()
    {
        if (_time >= 0)
        {
            _time_text.text = _time + " sec";
            game_time += 1 * Time.deltaTime;
        }

        if (game_time >= 1)
        {
            _time -= 1;
            game_time = 0;
        }
        else if (_time <= 10)
        {
            _time_text.color = Color.red;
        }


        if (int.Parse(_count.text) == max & _time != 0)
        {
            canvas.SetActive(true);
            _title.text = "You did great!";
            //_score.text = _count.text;

            count = int.Parse(_count.text);
            PlayerPrefs.SetInt("count_key", count);

            //winningSound.Play();
        }
        else if (_time == 0 & (int.Parse(_count.text) > min || int.Parse(_count.text) <= max || int.Parse(_count.text) == min))
        {
            canvas.SetActive(true);
            _title.text = "Time's up! You did great!";
            //_score.text = _count.text;

            count = int.Parse(_count.text);
            PlayerPrefs.SetInt("count_key", count);

            //winningSound.Play();
        }
        else if (_time == 0 & int.Parse(_count.text) < min)
        {
            canvas.SetActive(true);
            _title.text = "Time's up! You did okay...";
            //_score.text = _count.text;

            count = int.Parse(_count.text);
            PlayerPrefs.SetInt("count_key", count);

            //losingSound.Play();
        }

    }
}
