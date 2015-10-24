using UnityEngine;
using System.Collections;

public class IngredientSpawner : MonoBehaviour
{
    public GameObject[] ingredients;
    float spawnTime;

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
                int index = Random.Range(0, ingredients.GetLength(0));
                GameObject go = Instantiate(ingredients[index], transform.position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f))) as GameObject;
            }

            spawnTime = Time.time + 2.0f;
        }
    }
}
