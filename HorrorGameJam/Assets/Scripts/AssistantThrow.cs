using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AssistantThrow : MonoBehaviour
{
    Animation anim;
    List<Rigidbody2D> objectRbList = new List<Rigidbody2D>();

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        objectRbList.Add(rb);
        other.transform.parent = transform;
        anim.Play();
    }

    void Throw()
    {
        foreach(Rigidbody2D rb in objectRbList)
        {
            if (rb == null)
                continue;

            rb.isKinematic = false;
            rb.transform.parent = null;
            rb.velocity = new Vector2(-10.0f, 8.0f);
        }

        objectRbList.Clear();
    }
}
