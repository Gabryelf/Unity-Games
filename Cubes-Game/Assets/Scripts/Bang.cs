using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bang : MonoBehaviour
{
    public float size = 0.2f;
    public int row = 5;


    public int explosionForce = 100;
    public int explosionRadius = 2;
    public float explosionUpward = 0.4f;

    float pivotDistance;
    Vector3 pivot;

    void Start()
    {
        pivotDistance = size * row / 2;
        pivot = new Vector3(pivotDistance, pivotDistance, pivotDistance);


    }

    void Update()
    {


    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            Explode();
        }
    }
    private void Explode()
    {
        for (int x = 0; x < row; x++)
        {
            for (int y = 0; y < row; y++)
            {
                for (int z = 0; z < row; z++)
                {
                    CreatePiece(x, y, z);
                }

            }
        }
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, 2);

        foreach (Collider item in colliders)
        {
            Rigidbody rb = item.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
            }
        }

        Destroy(gameObject);
    }
    private void CreatePiece(int x, int y, int z)
    {
        GameObject piece;

        piece = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        piece.transform.position = transform.position + new Vector3(size * x, size * y, size * z) - pivot;
        piece.transform.localScale = new Vector3(size, size, size);

        piece.AddComponent<Rigidbody>().mass = size;

        Destroy(piece, 1);

    }
}
