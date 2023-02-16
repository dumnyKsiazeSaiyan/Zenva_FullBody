using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Color hitColor;
    public MeshRenderer _meshRenderer;


    private void OnCollisionEnter(Collision collision)
    {
        _meshRenderer.material.color = hitColor;

        collision.rigidbody.AddForce(Vector3.back * 10, ForceMode.Impulse);
    }
}
