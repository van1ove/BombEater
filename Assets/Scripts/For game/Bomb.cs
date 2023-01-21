using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] GameObject current;
    [SerializeField] float bombLifeTime = 7f;
    
    private bool lifeIsLost = false;
    
    void Start()
    {
        int number = Random.Range(0, 100);
        if (number <= 80)
        {
            current.GetComponent<SpriteRenderer>().color = Color.black;
        }
        else if (number > 60 && number <= 90)
        {
            current.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            current.GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        Destroy(current, bombLifeTime);
    }

    void Update()
    {
        if (!lifeIsLost && current.GetComponent<SpriteRenderer>().color != Color.red && current.GetComponent<Transform>().position.y < -7f)
        {
            FindObjectOfType<Lifes>().LoseLife();
            lifeIsLost = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (current.GetComponent<SpriteRenderer>().color == Color.black)
            {
                FindObjectOfType<Score>().GetOnePoint();
            }
            else if (current.GetComponent<SpriteRenderer>().color == Color.yellow)
            {
                FindObjectOfType<Score>().GetThreePoints();
            }
            else if (current.GetComponent<SpriteRenderer>().color == Color.red)
            {
                FindObjectOfType<Score>().LoseThreePoints();
                FindObjectOfType<Lifes>().LoseLife();
            }
            Destroy(current);
        }
    }
}
