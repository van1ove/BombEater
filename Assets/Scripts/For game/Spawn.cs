using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Arrays")]
    [SerializeField] GameObject [] bombArray;
    [SerializeField] Transform [] positions = new Transform [4];
    
    [Header("Timer")]
    [SerializeField] float spawnTime = 2f;
    private float timer = 0f;

    private int randObject;
    private int randPosition;
    void Start()
    {
        timer = spawnTime;
    }
    void Update()
    {
        if (timer <= 0)
        {
            randObject = Random.Range(0, bombArray.Length);
            randPosition = Random.Range(0, positions.Length);
            Instantiate(bombArray[randObject], positions[randPosition].transform.position, Quaternion.identity);
            timer = spawnTime;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
