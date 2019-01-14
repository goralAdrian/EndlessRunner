using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ToGame(){
		SceneManager.LoadScene("Unity");
	}
	public void ToLevel2(){
		SceneManager.LoadScene("poziom2");
	}
	public void ToLevel3(){
		SceneManager.LoadScene("poziom3");
	}
	public void Tabela(){
		SceneManager.LoadScene("wyniki");
	}
}