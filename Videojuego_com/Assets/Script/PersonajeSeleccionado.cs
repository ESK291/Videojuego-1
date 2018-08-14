using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeSeleccionado : MonoBehaviour {

	GameObject[] personajes = new GameObject[3];
	private void desactivar(){
		for (int i = 0; i < personajes.Length; i++) {
			personajes [i].SetActive (false);
		}
	} 
	void Start () {
		desactivar ();
		switch (Selecciondepersonaje.personaje) {
		case 0:
			personajes [0].gameObject.SetActive (true);
			break;
		case 1:
			personajes [1].gameObject.SetActive (true);
			break;
		case 2:
			personajes [2].gameObject.SetActive (true);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
