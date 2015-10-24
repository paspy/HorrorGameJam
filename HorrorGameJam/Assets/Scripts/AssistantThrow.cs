using UnityEngine;
using System.Collections;

public class AssistantThrow : MonoBehaviour
{
    Animation anim;
    Rigidbody2D objectRb;

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
        objectRb = other.GetComponent<Rigidbody2D>();
        objectRb.isKinematic = true;
        other.transform.parent = transform;
        anim.Play();
    }

    void Throw()
    {
        if (objectRb)
        {
            objectRb.isKinematic = false;
            objectRb.transform.parent = null;
            objectRb.velocity = new Vector2(-10.0f, 8.0f);
        }
    }
}
