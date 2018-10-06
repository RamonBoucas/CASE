using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void jogar()
    {
        Debug.Log("jogar");

    }

    public void créditos()
    {
        Debug.Log("creditos");

    }


    public void sair()
    {
       Debug.Log("sair");
          Application.Quit();

    }








}
