using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnpos = new Vector3(0, 0, 30);
    private float randomY;
    // Start is called before the first frame update
    void Start()
    {
        //para hacer aparecer los obstaculos a una distancia
        InvokeRepeating("SpawnObstacle", 0.5f, 5f);
    }

   //funcion para que aparezcan los obstaculos
    public void SpawnObstacle()
    {
        randomY = Random.Range(-10, 10);
        spawnpos = new Vector3(0, randomY, spawnpos.z + 50f);

        Instantiate(obstaclePrefab, spawnpos, obstaclePrefab.transform.rotation);
    }
}
