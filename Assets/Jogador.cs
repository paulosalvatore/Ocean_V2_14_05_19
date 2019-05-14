using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

	public GameObject projetilPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(
				projetilPrefab,
				Camera.main.transform.position,
				Camera.main.transform.rotation
			);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Zumbi"))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);
		}
	}
}
