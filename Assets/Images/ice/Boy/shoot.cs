using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
    public SpriteRenderer sprite;
    public GameObject projectile;
    public Vector2 velocity;
    bool canShoot = true;
    public Vector2 offset = new Vector2(0.4f, 0.1f);
    public float cooldown = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (sprite.flipX == true)
        {
            if (Input.GetKeyDown(KeyCode.F) && canShoot == true)
            {
                GameObject go = (GameObject)Instantiate(projectile, (Vector2)transform.position + offset * -1, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * -1, velocity.y);
                GetComponent<Animator>().SetTrigger("shoot");
            }
        }
        else {
            if (Input.GetKeyDown(KeyCode.F) && canShoot == true)
            {
                GameObject go = (GameObject)Instantiate(projectile, (Vector2)transform.position + offset, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x, velocity.y);
                GetComponent<Animator>().SetTrigger("shoot");
            }
        }

	}

    IEnumerator CanShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    }
}
