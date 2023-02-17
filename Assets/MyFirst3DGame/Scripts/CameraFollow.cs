using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject playerPos;
    public Vector3 targetPosition;
    public Vector3 offset;

    private void Start()
    {
        playerPos = GameObject.Find("Player");
        offset = transform.position;

    }

    private void Update()
    {
        targetPosition = playerPos.transform.position;
        transform.position = targetPosition + offset;
    }

}

