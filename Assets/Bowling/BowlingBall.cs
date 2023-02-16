using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    public float forwardForce;
    public float leftBorder;
    public float rightBorder;
    public float moveIncrement;
    public Rigidbody rig;


    public void Bowl()
    {
        rig.AddForce(Vector3.forward * forwardForce, ForceMode.Impulse);
    }

    public void MoveLeft()
    {
        if (transform.position.x > leftBorder)
        {
            transform.position += (Vector3.left * moveIncrement);
        }


    }

    public void MoveRight()
    {
        if (transform.position.x < rightBorder)
        {
            transform.position += (Vector3.right * moveIncrement);
        }


    }
}
