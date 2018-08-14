using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selecciondepersonaje : MonoBehaviour {

	public static int personaje;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void seleccionar_p(int p){
		personaje = p;
	}

	public void escena(string nombre){
		SceneManager.LoadScene (nombre);
	}

}
