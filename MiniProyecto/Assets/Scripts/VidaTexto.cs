using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaTexto : MonoBehaviour {
	public VidaJugador vidaJugador;
	public Text texto;
	// Use this for initialization
	void Start () {
		GameObject jugador = GameObject.Find("Jugador");
		vidaJugador = jugador.GetComponent<VidaJugador>();
		texto = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		actualizarVida();
	}

	void actualizarVida () {
		texto.text = vidaJugador.vida +  "";
	}
}
