using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    public GameObject Wall;
    [SerializeField] AudioSource audio3;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            audio3.Play();
            Wall.SetActive(false);
            
            //Destroy(gameObject);
        }
    }
}
