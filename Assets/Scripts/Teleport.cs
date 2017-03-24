using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
    private GameObject currentPortal;
    [SerializeField]
    private GameObject nextPortal;
    private GameObject target;
	// Use this for initialization
	void Start () {
        var cPortal = currentPortal.transform.position;
        var nPortal = nextPortal.transform.position;
        print(cPortal + " " + nPortal);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnTriggerStay2D(Collider2D other) {
        currentPortal = gameObject;
        target = GameObject.FindWithTag("Player");
        var targetV = target.transform.position;
        var cPortal = currentPortal.transform.position;
        var nPortal = nextPortal.transform.position;

        if ( other.gameObject.tag == "Player" && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            print(cPortal + " " + nPortal);
            target.transform.position = new Vector3(nPortal.x, nPortal.y, nPortal.z);
        }
    }
}
