using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {


	private Rigidbody2D playerRb;
	private SpriteRenderer playerSprite;
	public float velocidade;
	public bool flipX = false;


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
}
