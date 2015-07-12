using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour {
	
	public float speed = 0;
	public float slowDown = .05f;
	public float increase;
	
	void Start() {

	}
	void Update () {
		speed += 0.001f;

		if (!Input.GetKeyDown(KeyCode.Space) && speed >= 0.001f){
			//speed -= 0.001f;
		}
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			speed+= 0.100f;
		}
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (increase + speed, 0f);
	}
}
