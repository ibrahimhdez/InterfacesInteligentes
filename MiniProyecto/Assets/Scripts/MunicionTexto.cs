using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MunicionTexto : MonoBehaviour {
	public Arma arma;
	public Text texto;

	// Use this for initialization
	void Start () {
		arma = GameObject.Find("SciFiGunLightRad").GetComponent<Arma>();
		texto = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		actualizarMunicion();
	}

	void actualizarMunicion () {
		texto.text = arma.municion + " / " + arma.cargadorCapacidad;
	}
} 
