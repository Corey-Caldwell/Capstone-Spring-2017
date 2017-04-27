using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorspike : MonoBehaviour {
    // Use this for initialization
    public float speed;
    private float velocity;
    public float max;
    private float min;
    void Start () {
        min = gameObject.transform.position.y;

    }
	
	// Update is called once per frame
	void Update () {
        var spike = gameObject.transform;
        
        if (spike.position.y <= min)
        {
            velocity = Random.value;

        }
        if (spike.position.y >= max)
        {
            velocity = -Random.value;
        }
        spike.Translate(Vector3.up * (velocity*speed * Time.deltaTime));
    }
}
