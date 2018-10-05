using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour {

    public GameObject meuTiroPlayer;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(meuTiroPlayer, transform.position, transform.rotation);

        }






		
	}
}
