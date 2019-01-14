using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMotor : MonoBehaviour {

	private CharacterController controller;
	private Vector3 moveVector;
	private float speed = 5.0f;
	private float verticalVelocity = 0.0f;
	private float gravity = 12f;
	private float startTime;
	
	private bool isDead = false;
	///private bool menumenu = false;
	
	void Start () {
		controller = GetComponent<CharacterController> ();
		startTime = Time.time;
	}

	void Update () {
		if(isDead){
			return;
		}
		moveVector = Vector3.zero;
		
		
		if(controller.isGrounded){
			verticalVelocity = -0.5f;
		}else{
			verticalVelocity -= gravity * Time.deltaTime;
		}
		
		// x - left and right
		moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
		// y - up and down
		moveVector.y = verticalVelocity;
		// z - forward and reverse
		moveVector.z = speed;
		
		controller.Move(moveVector * Time.deltaTime);
		if(moveVector.z == 330.0f){
			SceneManager.LoadScene("restart");
		}
		if(moveVector.y < (-5.0f)){
			SceneManager.LoadScene("restart");
		}
	}
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
		
		if(transform.position.z > 330.0f)
		{
			Death();
			Debug.Log("Koniec");
			SceneManager.LoadScene("restart");
			
		}
	}
	private void Death()
	{
		isDead = true;
		Debug.Log("Snek");
	}
	public void setSpeed(float modifier)
	{
		speed = 5.0f + modifier;
	}
}