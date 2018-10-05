using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour {


    public float tempoEntreAtaque;
    public float tempoMinimoEntreAtaque;

    public Transform posicaoAtaque;
    public float raio;

    public LayerMask inimigos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (tempoEntreAtaque <= 0)
        {
            tempoEntreAtaque = tempoMinimoEntreAtaque;

            if (Input.GetKey(KeyCode.Space))
            {

                Collider2D[] inimigosAtingidos = Physics2D.OverlapCircleAll(posicaoAtaque.position,raio,inimigos); 

            }





        }
        else
        {
            tempoEntreAtaque -= Time.deltaTime;
        }


	}
}
