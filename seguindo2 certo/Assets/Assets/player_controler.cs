using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float speed;

	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(horizontal, vertical);

        transform.position += dir * speed * Time.deltaTime;
	}
}
