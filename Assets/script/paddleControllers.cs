using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleControllers : MonoBehaviour
{

    public int speed;
    public KeyCode upkey;
    public KeyCode downkey;

    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        //ambil input
        if (Input.GetKey(upkey))
        {
            //gerakan ke atas
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downkey))
        {
            //gerakan ke bawah
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 direction)
    {
        //gerakan object pake input
        rig.velocity = direction ;
    }
}
