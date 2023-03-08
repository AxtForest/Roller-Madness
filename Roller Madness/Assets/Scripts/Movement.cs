using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private float a, b,hiz;
    private Rigidbody rg;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        MoveThePlayer();
        
    }
    private void MoveThePlayer()
    {
        a = Input.GetAxis("Horizontal");
        b = Input.GetAxis("Vertical");
        movement = new Vector3(a * hiz * Time.deltaTime, 0f, b * hiz * Time.deltaTime);
        rg.AddForce(movement);
        //transform.position += movement;
    }
}
