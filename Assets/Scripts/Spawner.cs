using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Enemy _template;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        int timeBetweenSpawn = 2;
        WaitForSeconds delay = new WaitForSeconds(timeBetweenSpawn);

        while (true)
        {
            for (int i = 0; i < _spawnPoints.Length; i++)
            {
                Instantiate(_template, _spawnPoints[i].position, Quaternion.identity, _spawnPoints[i]);
                yield return delay;
            }
        }
    }
}
