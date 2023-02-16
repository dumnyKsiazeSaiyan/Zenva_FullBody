using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveForce;
    public Rigidbody _rigidBody;

    private void FixedUpdate()
    {
        float xAxis = Input.GetAxis("Horizontal");

        _rigidBody.AddForce(moveForce * xAxis * Vector3.right);
    }
}
