using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour {
	
	public float speed = 0;

	public float speed;
	public float slowDown;
	public float offset;
	//float t;
	//float newTime;
		
	void Start()
	{
		rend = GetComponent<Renderer> ();
		speed = 0f;
		slowDown = .005f;
	//	t = 0f;
	}

	void Update()
	{
	//	newTime = Time.time - t;
		offset += speed;// * newTime;
		rend.material.mainTextureOffset = new Vector2 (offset, 0);
	}

	void FixedUpdate ()
	{
		SlowDown ();
		SpeedUp ();
	}

	void SlowDown()
	{
		speed -= slowDown * Time.deltaTime;
		if (speed < 0f)
		{
			speed = 0f;
		}
		return;
	}

	void SpeedUp()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			speed += 0.1f * Time.deltaTime;
		//	t = Time.time;
		}
	}
}
