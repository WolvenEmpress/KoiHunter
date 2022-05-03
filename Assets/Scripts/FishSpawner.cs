using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] enemiesToSpawn;
    void Update()
    {
        if(Random.Range(1,100) <15)
        {
            Vector3 spawnPosition = this.transform.position;
            spawnPosition.y += Random.Range(-150f,150f);

            int randomEnemyPosition = Random.Range(0,9);

            Instantiate(enemiesToSpawn[randomEnemyPosition], spawnPosition, Quaternion.identity);

        }


    }
}
