using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class Choque : MonoBehaviour {

	public GameObject cubo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "cubo1") 
		{
			c.gameObject.SetActive (false);
		//	cubo = GameObject.FindGameObjectWithTag ("cubo2");
			cubo.gameObject.SetActive (true);
			CarAIControl.cuboSeleccionado = 2;

		}
	}
}
