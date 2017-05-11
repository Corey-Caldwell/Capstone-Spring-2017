using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowball : MonoBehaviour {
    public Rigidbody2D rb;
    public Vector2 velocity;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 10);
        rb = GetComponent<Rigidbody2D>();
        velocity = rb.velocity;	
	}
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.y < velocity.y) {
            rb.velocity = velocity;
        }
        Explode();
	}
    void OnCollisionEnter2D(Collider2D col) {
        rb.velocity = new Vector2(velocity.x, -velocity.y);
        if (col.tag == "Enemy" || col.tag == "Spike" || col.tag == "Ground") {
            Destroy(col.gameObject);
            Explode();
        }
    }


    void Explode() {
        Destroy(this.gameObject);
    }
}
