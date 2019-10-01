using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Swimmer player;
    public VectorField2D field;
    [HideInInspector] public PlayerInputController pic;

    private void Awake()
    {
        pic = GetComponent<PlayerInputController>();
        if (pic != null && player != null && field != null)
        {
            pic.player = player;
            player.SetBounds(field.GetBounds());
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && field != null)
        {
            Vector3 displacement = field.CalculateForce(player.transform.position);
            player.ApplyDisplacement(displacement);
        }
    }

}
