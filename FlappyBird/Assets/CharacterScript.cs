using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += (Vector3.down * Time.deltaTime*2);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime*15);
            transform.Translate(Vector3.up * Time.deltaTime * 10);
            transform.Translate(Vector3.up * Time.deltaTime * 10);
            transform.Translate(Vector3.up * Time.deltaTime * 10);
            Debug.Log(transform.position.y);
        }
        if (transform.position.y >= 5)
        {
            transform.position = new Vector3(0, 5, 0);
        }
        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
	}
}
