using System;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{


    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 5))
        {
            print(gameObject.name);
        }
        else
        {
            print("Nothing ahead.");
        }
    }
}
