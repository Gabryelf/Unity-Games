using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShildCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            //other.GetComponent<SnakeMove>().AddTail();
            Destroy(gameObject);
        }
    }
}
