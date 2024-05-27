using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public BirdController BirdScript;
    public GameObject Borular;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!BirdScript.isDead)
        {

            Instantiate(Borular, new Vector3(5, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);


        }
    }
}
