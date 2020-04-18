using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float speed = 5f;
    private Vector2 position;
    public float maxpos = 3.4f;

   public  uimanager ui;
	// Use this for initialization
	void Start () {

        position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        position.x += SimpleInput.GetAxis("Horizontal")*speed*Time.deltaTime;
       position.x= Mathf.Clamp(position.x,-4.23f,4.47f);
        transform.position = position;

		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
        ui.gm();
       
    }

}
