using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMF3G : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public Vector3 moveOffset;
    private Vector3 targetPos;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
        targetPos = startPos;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        //je¿eli dotrze do celu to
        if (transform.position == targetPos)
        {
            // je¿eli cel to pozycja startowa to ustaw pozStart + offset
            if(targetPos == startPos)
            {
                targetPos = startPos + moveOffset;
            }
            // je¿eli cel to nie pozycja startowa, ustaw cel na pozycje startow¹
            else
            {
                targetPos = startPos;
            }
        }

         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerControllerX>().GameOver();
        }
    }


}
