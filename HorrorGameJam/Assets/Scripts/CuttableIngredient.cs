using UnityEngine;
using System.Collections;

public class CuttableIngredient : MonoBehaviour
{
    public GameObject[] parts;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        foreach (GameObject go in parts)
        {
            GameObject part = Instantiate(go, transform.position, transform.rotation) as GameObject;
            part.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * 5.0f;
        }
        Destroy(gameObject);
    }
}
