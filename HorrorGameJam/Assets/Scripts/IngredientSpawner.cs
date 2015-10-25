using UnityEngine;
using System.Collections;

public class IngredientSpawner : MonoBehaviour
{
    public GameObject[] ingredients;
    public GameObject smokeEffect;
    float spawnTime;
    public GameObject spawnEffect;

    // Use this for initialization
    void Start()
    {
        spawnTime = Time.time + 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= spawnTime)
        {
            if (ingredients.GetLength(0) > 0)
            {
                Invoke("SpawnObject", 0.5f);

                if (spawnEffect)
                {
                    Instantiate(spawnEffect, transform.position, Quaternion.identity);
                }
            }

            spawnTime = Time.time + 2.0f;
        }
    }

    void SpawnObject()
    {
        int index = Random.Range(0, ingredients.GetLength(0));
        GameObject go = Instantiate(ingredients[index], transform.position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f))) as GameObject;
    }
}
