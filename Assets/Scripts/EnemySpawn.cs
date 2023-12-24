using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float distance = 10;
    public float interval = 3.0f;
    public float time = 0;
    public GameObject enemyPrefab;


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (interval < time)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            float randomAngle = Random.Range(0, 360);
            Quaternion quaternion = Quaternion.Euler(0, randomAngle, 0);
            enemy.transform.position = quaternion * new Vector3(0, 0, distance);
            time = 0;
        }
        
    }
}
