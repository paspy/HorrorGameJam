﻿using UnityEngine;
using System.Collections;

public class Pot : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // TODO: Added ingredient to final result
        Destroy(other.gameObject);
    }
}
