using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimmer : MonoBehaviour
{

    public float energy = 1.0f;
    public float fear = 0;
    public float ability = 0.5f;

    private Vector3 displacement;
    private Bounds bounds;

    // Start is called before the first frame update
    void Start()
    {
        displacement = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (bounds != null && bounds.Contains(transform.position))
        {
            transform.position += displacement * Time.deltaTime;
        }

        displacement = Vector3.zero;
    }

    public void ApplyDisplacement(Vector3 v)
    {
        displacement += v;
    }

    public void Swim(Vector3 dir)
    {
        displacement += dir * ability;
    }

    public void SetBounds(Bounds bounds)
    {
        this.bounds = bounds;
    }
}
