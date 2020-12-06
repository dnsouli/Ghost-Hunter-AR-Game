using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] balloons;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(2);

        //for(int i = 0; i < 3; i++)
        //{
            Instantiate(
                balloons[Random.Range(0, balloons.Length)],
                spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.Euler(0, -180, 0));
        //}

        StartCoroutine(StartSpawning());
    }

}
