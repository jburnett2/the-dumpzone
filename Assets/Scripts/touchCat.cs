using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchCat : MonoBehaviour {

    public Sprite untouch;
    public Sprite touch;

    private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = untouch;
	}
	
	// Update is called once per frame
	void Update () {

    
    }

    private void OnMouseDown()
    {
        sr.sprite = touch;
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.25f, transform.position.z);
    }

    private void OnMouseUp()
    {
        sr.sprite = untouch;
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.25f, transform.position.z);
    }

}
