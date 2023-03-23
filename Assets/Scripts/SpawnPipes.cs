using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipeprefab;

    private float nextPipeTime;

    public float spawnInterval = 1;

    public float randomHeight;

    public CoinSystem coinSystem;

    void Start()
    {
        nextPipeTime = Time.time;
    }


    void Update()
    {
  
        if (coinSystem.TransitioningToFinalBossLevel1000GodLikeHardSkillBigPro != true) {
            if (Time.time > nextPipeTime)
            {
                Vector3 position = transform.position;
                position += Vector3.up * Random.Range(-randomHeight, randomHeight);
                Instantiate(pipeprefab, position, Quaternion.identity);
                nextPipeTime += spawnInterval;
            }
        }
    }
}
