using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementM : MonoBehaviour {
    public float speed;
    public float jump;
    Rigidbody rb;
	void Start () {
        rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.H))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.U))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.B))
        {
            transform.position += Vector3.up * speed * jump * Time.deltaTime;
        }
    }
}
