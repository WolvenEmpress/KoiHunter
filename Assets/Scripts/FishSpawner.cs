using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] enemiesToSpawn;
    void Update()
    {
        if(Random.Range(1,100) <2)
        {
            Vector3 spawnPosition = this.transform.position;
            spawnPosition.y += Random.Range(-15f,15f);

            int randomEnemyPosition = Random.Range(0,8);

            Instantiate(enemiesToSpawn[randomEnemyPosition], spawnPosition, Quaternion.identity);

        }


    }
}
