using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider))]
public class VectorField2D : MonoBehaviour
{
    public float strength = 0.3f;
    private Bounds bounds;

    void Awake()
    {
        bounds = gameObject.GetComponent<Collider>().bounds;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 CalculateForce(Vector3 point)
    {
        if (bounds.Contains(point))
        {
            return Vector3.back * strength;
        } else
        {
            return Vector2.zero;
        }
    }

    public Bounds GetBounds()
    {
        return bounds;
    }
}
