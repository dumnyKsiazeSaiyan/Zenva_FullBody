using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMF3G : MonoBehaviour
{
    public float rotateSpeed = 180.0f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerControllerX>().AddScore(1);
            Destroy(gameObject);
        }
    }
}
