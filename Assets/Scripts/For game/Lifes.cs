using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifes : MonoBehaviour
{
    [SerializeField] Image [] lifes = new Image[3];
    public int healthForArray = 2;

    void Start()
    {
        for (int i = 0; i <= lifes.Length - 1; i++)
        {
            lifes[i].gameObject.SetActive(true);
        }
    }
    public void LoseLife()
    {
        if (healthForArray >= 0)
        {
            lifes[healthForArray].gameObject.SetActive(false);
            healthForArray--;
        }
    }
}
