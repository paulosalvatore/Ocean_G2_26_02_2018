using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogador : MonoBehaviour {

	public float forcaPulo = 100f;

	private int pontos = 0;

	private Rigidbody rb;

	public Text pontosText;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Pular ();
		}
	}

	void Pular() {
		rb.velocity = Vector3.zero;

		rb.AddForce (Vector3.up * forcaPulo);
	}

	void OnCollisionEnter(Collision colisao) {
		if (colisao.gameObject.CompareTag("Inimigos")) {
			Invoke ("ReiniciarJogo", 2f);
		}
	}

	void ReiniciarJogo() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.CompareTag ("ZonaPontos")) {
			pontos = pontos + 1;

			pontosText.text = "Pontos: " + pontos;
		}
	}
}
