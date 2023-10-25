using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingData : MonoBehaviour
{

    int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Highscore: " + GetNumber());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            number++;
            if(number > GetNumber())
            {
                PlayerPrefs.SetInt("HighestScore", number);
            }
            Debug.Log(number);
        }
    }

    public int GetNumber()
    {
        int highestScore = PlayerPrefs.GetInt("HighestScore", 0);
        return highestScore;
    }
}
