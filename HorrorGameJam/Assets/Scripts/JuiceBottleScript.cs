using UnityEngine;
using System.Collections;

public class JuiceBottleScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDrag()
    {
        HingeJoint2D hinge = GetComponent<HingeJoint2D>();

        if (!hinge)
        {
            hinge = gameObject.AddComponent<HingeJoint2D>();
        }

        Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hinge.connectedAnchor = cursorPosition;
    }

    void OnMouseUp()
    {
        HingeJoint2D hinge = GetComponent<HingeJoint2D>();

        if (hinge)
        {
            Destroy(hinge);
        }
    }
}
