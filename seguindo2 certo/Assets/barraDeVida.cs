using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barraDeVida : MonoBehaviour {


    public float Saude;
    public float SaudeMaxima;
    public float TamanhoPadrao;

    public Transform Barra;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float fracaoSaude = calculaFracaoSaude(Saude, SaudeMaxima);
        float tamanhoBarra = calculaTamanhoBarra(TamanhoPadrao, fracaoSaude);
        atualizaBarra(tamanhoBarra);
    }

    public void atualizaBarra(float tamanhoBarra)
    {
        Barra.localScale.Set(tamanhoBarra, 10, 1);

      //  Barra.position.Set(Barra.position.get)

        Debug.Log(tamanhoBarra);

    }

    public float calculaFracaoSaude(float saude,float saudeMaxima)
    {
        return (saude / saudeMaxima);
    }

    public int calculaTamanhoBarra(float tamanhoPadrao,float fracaoSaude)
    {
        return (int)(tamanhoPadrao * fracaoSaude);
    }






}
