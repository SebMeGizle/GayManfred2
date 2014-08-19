using UnityEngine;
using System.Collections;

public class playerPhysics : MonoBehaviour {

	public void Move(Vector2 distMoved) {

		transform.Translate (distMoved);
}