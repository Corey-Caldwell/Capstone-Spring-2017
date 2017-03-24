using UnityEngine;
using System.Collections;

public class SpringScript : MonoBehaviour {
	
	private bool bounceBool = false;
	
	[SerializeField]
	private float bounceForce = 1000;
	
	private GameObject Player;
	public Vector2 velocity;
	
	void Start()
	{
		
	}
	
	void Update()
	{
		//if(bounceBool == true)
		//{
			//Player.transform.GetComponent<Rigidbody2D>().velocity = new Vector2(bounceForce, GetComponent<Rigidbody2D>().velocity.y);
			//Player.transform.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.y, bounceForce);
			//Player.transform.GetComponent<Rigidbody2D>().AddForce(0, bounceForce, 0, ForceMode.Impulse);
			//Player.GetComponent<Rigidbody2D>().AddForce(transform.up * bounceForce);
			//Player.Rigidbody2D.velocity *= new Vector3(1, 0, 1);
			//bounceBool = false;
			
		//}
	}
	
	void OnCollisionStay2D(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Player = other.gameObject;
			//Player = GetComponent<Rigidbody2D>();
			//other.gameObject.GetComponent<PlayerControl>().speed = velocity.x;
			//bounceBool = true;
		}
	}
	
	void Jump()
	{
		Player.GetComponent<Rigidbody2D>().velocity = velocity;
	}

}