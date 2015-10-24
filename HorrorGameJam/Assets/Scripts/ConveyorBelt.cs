using UnityEngine;
using System.Collections;

public class ConveyorBelt : MonoBehaviour
{
    public bool reversed = false;

    // Use this for initialization
    void Start()
    {
        GetComponent<Animator>().SetBool("Reverse", reversed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D coll)
    {
        Rigidbody2D rb = coll.gameObject.GetComponent<Rigidbody2D>();

        if (rb)
        {
            if (!reversed)
            {
                if (rb.velocity.x < 1.0f)
                {
                    rb.AddForceAtPosition(new Vector2(10.0f, 0.0f), coll.contacts[0].point);
                    Debug.DrawLine(coll.contacts[0].point, coll.contacts[0].point + new Vector2(5.0f, 0.0f));
                }
            }
            else
            {
                if (rb.velocity.x > -1.0f)
                {
                    rb.AddForceAtPosition(new Vector2(-10.0f, 0.0f), coll.contacts[0].point);
                    Debug.DrawLine(coll.contacts[0].point, coll.contacts[0].point + new Vector2(-5.0f, 0.0f));
                }
            }
        }
    }
}
