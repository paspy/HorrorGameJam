using UnityEngine;
using System.Collections;

public class ConveyorBelt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStay2D(Collision2D coll)
    {
        Rigidbody2D rb = coll.gameObject.GetComponent<Rigidbody2D>();

        if (rb)
        {
            rb.velocity = new Vector2(1.0f, 0.0f);
        }
    }
}
