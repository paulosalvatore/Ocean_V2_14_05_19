using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour {

	public float delay = 2f;
	public float area = 4f;

	public GameObject zumbiPrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating("GerarZumbi", delay, delay);
	}
	
	// Update is called once per frame
	void GerarZumbi () {
		var zumbi = Instantiate(zumbiPrefab);

		var posicaoAleatoria = Random.insideUnitCircle * area;
		zumbi.transform.position = new Vector3(
			posicaoAleatoria.x,
			zumbi.transform.position.y,
			posicaoAleatoria.y
		);
	}
}
