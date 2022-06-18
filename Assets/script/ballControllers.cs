using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControllers : MonoBehaviour
{
    public Vector2 direction;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = direction;
    }

    // Update is called once per frame
    void Update()
    {
        //bentuk basic
        //transform.position = transform.position + (new Vector3(1f,0,0)*Time.deltaTime);
        //bentuk sederhana
        //transform.Translate(direction * Time.deltaTime);
    }
}
