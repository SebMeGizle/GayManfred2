using UnityEngine;
using System.Collections;

[RequireComponent(typeof(playerPhysics))]
public class playerControls : MonoBehaviour {

	// player controls

	public float speed =8;
	public float acceleration=12;

	private float currentSpeed;
	private float maxSpeed;
	private Vector2 distToMove;

	private playerPhsyics playerPhysics; 


	void Start () {
		playerPhsyics = GetComponent<playerPhysics>(); 

	}
	
	// Update is called once per frame
	void Update () {
	
		maxSpeed = Input.GetAxisRaw ("Horizontal") * speed;
		currentSpeed = IncrementTowards (currentSpeed, maxSpeed, acceleration);

		distToMove = new Vector2 (currentSpeed, 0);
		playerPhysics.Move (distToMove * Time.deltaTime);
	}

	// increase speed through acceleration/ using increment method

	private float IncrementTowards (float n, float target, float a) {
		if (n== target) {
			return n; 
		}
		else { 
			float dir = Mathf.Sign (target - n);  
			n += speed * Time.deltaTime * dir;
			return (dir == Mathf.Sign(target-n))? n: target; 

		}
	}


}
