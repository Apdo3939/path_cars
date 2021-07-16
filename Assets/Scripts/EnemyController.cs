using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int maxCars = 5;

    public GameObject enemyCarPrefab;

    public Transform respawnPosition;

    private GameObject[] listEnemycars;

    [Space(10)]
    public float timeToSpawn = 3.0f;
    public float timeToRepeatSpawn = 2.0f;

    [Space(10)]
    public float[] respawnPositions = new float[3];

    // Start is called before the first frame update
    void Start()
    {
        listEnemycars = new GameObject[maxCars];

        for (int i = 0; i < maxCars; i++)
        {
            GameObject go = Instantiate(enemyCarPrefab, respawnPosition.position, respawnPosition.rotation);

            go.SetActive(false);
            listEnemycars[i] = go;
        }

        InvokeRepeating("SpawnCar", timeToSpawn, timeToRepeatSpawn);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCar()
    {
        for (int i = 0; i < listEnemycars.Length; i++)
        {
            if (!listEnemycars[i].activeInHierarchy)
            {
                GameObject go = listEnemycars[i];
                
                go.SetActive(true);

                go.name = string.Format("EnemyCar-0{0}", (i + 1).ToString());
                
                float posX = respawnPositions[Random.Range(0, respawnPositions.Length)];

                go.transform.position = new Vector3(
                    posX, 
                    respawnPosition.position.y,
                    respawnPosition.position.z
                );

                Material[] mats = go.GetComponentInChildren<Renderer>().materials;
                mats[1].color = GetRandomColor();

                return;
            }
        }
    }

    private Color GetRandomColor(){
        return Random.ColorHSV(0f,1f,1f,1f, 0.5f, 1f);
    }
}
