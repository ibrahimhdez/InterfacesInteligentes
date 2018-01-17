using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour {

	public float vida = 20f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void PerderVida(float cantidad) {
		vida -= cantidad;

		if (vida <= 0f) {
			//Destroy (gameObject);

			GameObject controlador = GameObject.Find ("Controlador");
			controlador.GetComponent<ControladorJuego> ().gameOver();
		}
	}
}
