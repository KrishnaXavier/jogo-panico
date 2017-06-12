using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class espinho : MonoBehaviour {

	private Rigidbody2D espinhoRb;
	private int atrito;
	public int atritoMaximo, atritoMinimo;
	public Vector3 posicao;
	public GameObject espinhoPrefab;

	public  int pontuacaoVencer = 50;


	// Use this for initialization
	void Start () {
		espinhoRb = GetComponent<Rigidbody2D> ();	
		atrito = Random.Range (atritoMinimo, atritoMaximo);
		espinhoRb.drag = atrito;

		posicao = transform.position;
	}
	
	void OnBecameInvisible(){
		Instantiate (espinhoPrefab, posicao, transform.localRotation);
		pontuacao.pontos += 1;
		Destroy (this.gameObject);
		if (pontuacao.pontos > pontuacaoVencer) {
			SceneManager.LoadScene ("ganhou");	
		}
	}
}
