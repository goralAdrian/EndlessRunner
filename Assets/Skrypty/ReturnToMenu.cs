using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Powrot(){
		SceneManager.LoadScene("Menu");
	}
}
