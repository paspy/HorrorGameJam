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
            for (int i = 0; i < ingredients.GetLength(0); i++)
            {
                GameObject go = Instantiate(ingredients[i], transform.position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f))) as GameObject;
                go.GetComponent<Rigidbody2D>().velocity = new Vector2(-8.0f, 8.0f);
            }

            spawnTime = Time.time + 2.0f;
        }
    }
}
