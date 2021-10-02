using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	public float minX, maxX;
	private Ball ball;
	
	//Screen.showCursor=false says that once the player has clicked to launch the ball
	//the mouse cursor will vanish from view. this will return upon game loss
	void Start() {
		Screen.showCursor = false; 
		ball = GameObject.FindObjectOfType<Ball>();
		
	}
	
	// Update is called once per frame
	//this means that every frame the code will check to see where the players mouse is
	//and will move the Paddle accordingly
	void Update () {
		if (!autoPlay) {
			MoveWithMouse();
		}else{
			AutoPlay();
		}
	}
	// The game will play its self using this code
	void AutoPlay() {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, minX, maxX);
		this.transform.position = paddlePos;
	
	}
	//The player will control the Paddle using their mouse to move left or right
	void MoveWithMouse () {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width *16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, maxX);
		this.transform.position = paddlePos;
	}
}






