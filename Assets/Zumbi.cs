using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour {

	Animator animator;

	Transform jogador;

	public float velocidade = 1f;

	bool morto = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

		jogador = GameObject.Find("Jogador").transform.Find("Pivot");
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(jogador);

		if (!morto)
		{
			var direcao = (jogador.position - transform.position).normalized;
			transform.Translate(direcao * velocidade * Time.deltaTime, Space.World);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!morto && other.CompareTag("Projétil"))
		{
			//Destroy(gameObject);
			animator.SetTrigger("Morrer");
			Destroy(other.gameObject);
			morto = true;
		}
	}
}
