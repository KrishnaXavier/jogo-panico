using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {


	private Rigidbody2D playerRb;
	private SpriteRenderer playerSprite;
	public float velocidade;
	public bool flipX = false;
	public int pontuacaoPerder = -50;


	// Use this for initialization
	void Start () {
		playerRb = GetComponent<Rigidbody2D> ();
		playerSprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {			
			velocidade *= -1;
			flipX = !flipX;
			playerSprite.flipX = flipX;
		}

		playerRb.velocity = new Vector2 (velocidade, 0);
				
	}

	void OnCollisionEnter2D(Collision2D colisao){
		if (colisao.gameObject.tag == "espinho"){			
			pontuacao.pontos -= 2;
			if (pontuacao.pontos < pontuacaoPerder) {
				SceneManager.LoadScene ("gamerover");	
			}
		}
	}

	void OnTriggerEnter2D(Collider2D colisao){
		if (colisao.gameObject.tag == "espinho"){
			pontuacao.pontos -= 2;
			if (pontuacao.pontos < pontuacaoPerder) {
				SceneManager.LoadScene ("gamerover");	
			}		}
	}
		
}
