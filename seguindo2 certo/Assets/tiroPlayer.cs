using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroPlayer : MonoBehaviour {


    public float minhaVelocidade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * minhaVelocidade * Time.deltaTime);
	}
}
