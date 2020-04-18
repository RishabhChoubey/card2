using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movertraack : MonoBehaviour {
    public float speed = 5f;
   public Renderer red;
    Vector2 offset;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        offset = new Vector2(0, speed*Time.time);
        red.material.mainTextureOffset =offset;  
	}
}
