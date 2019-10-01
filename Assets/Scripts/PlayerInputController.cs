using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [HideInInspector] public Swimmer player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;
        if (Input.GetKey("up"))
        {
            dir += Vector3.forward;
        }

        if (Input.GetKey("down"))
        {
            dir += Vector3.back;
        }

        if (Input.GetKey("left"))
        {
            dir += Vector3.left;
        }

        if (Input.GetKey("right"))
        {
            dir += Vector3.right;
        }

        if (player != null)
        {
            player.Swim(dir);
        }
    }
}
