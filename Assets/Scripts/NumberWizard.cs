using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;


    void Start()
    {
        StarGame();
    }

    void StarGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        if (guess == 1000)
        {
            min = 1000;
            max = 1000;
        }
        else
        {
            min = min < max ? guess + 1 : min;
            NextGuess();
        }
    }


    public void OnPressLower()
    {
        if (guess == 1)
        {
            min = 1;
            max = 1;
        }
        else
        {
            max = max > min ? guess - 1 : max;
            NextGuess();
        }
    }

    void NextGuess()
    {
        if (min <= max) {
            guess = Random.Range(min, max + 1);
            guessText.text = guess.ToString();
        }
    }
}
