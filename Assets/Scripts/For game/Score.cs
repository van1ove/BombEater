using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    void Start()
    {
        score.text = "0";
    }

    public void GetOnePoint()
    {
        score.text = (int.Parse(score.text) + 1).ToString();
    }

    public void GetThreePoints()
    {
        score.text = (int.Parse(score.text) + 3).ToString();
    }

    public void LoseThreePoints()
    {
        if (int.Parse(score.text) < 3)
        {
            score.text = "0";
        }
        else
        {
            score.text = (int.Parse(score.text) - 3).ToString();
        }
    }
}
