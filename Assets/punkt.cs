using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class punkt : MonoBehaviour {
 public Text Score;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void zapisz()
	{
		int number = 0;
		Score.text = number.ToString();
	}
}
