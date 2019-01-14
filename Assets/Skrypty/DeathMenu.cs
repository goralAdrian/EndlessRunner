using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	}

	
	// Update is called once per frame
	void Update () {

	}
	public void Restart(){
		SceneManager.LoadScene("Menu");
	}
	public void ToMenu(){
		SceneManager.LoadScene("unity");
	}
	

}