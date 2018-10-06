using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class novoBarraVida : MonoBehaviour {

    public Image barraVidaUI;
    public float vidaMaxima;
    public float vidaAtual;


	// Use this for initialization
	void Start () {
        vidaAtual = vidaMaxima;
	}
	
	// Update is called once per frame
	void Update () {

        float fracaoVida = (vidaAtual / vidaMaxima);


        barraVidaUI.rectTransform.sizeDelta = new Vector2(fracaoVida*  200, 20);
	}
}
