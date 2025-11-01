using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private void Start()
    {
        float spawnPosX = Random.Range(-9, 9);
        float spawnPosZ = Random.Range(-9, 9);
        Vector3 randomPos = new Vector3(spawnPosX, 0 , spawnPosZ);

        Instantiate(enemyPrefab, randomPos, enemyPrefab.transform.rotation);
    }
}
