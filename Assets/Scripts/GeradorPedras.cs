using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorPedras : MonoBehaviour {

	public GameObject pedrasPrefab;

	public float intervaloPedras = 3f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CriarPedra", intervaloPedras, intervaloPedras);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CriarPedra() {
		Instantiate (pedrasPrefab);
	}
}
