using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carswar : MonoBehaviour {
    public GameObject[] cars;
    int carno;
    public float maxp = 3.4f;
    public float time=100f;
    float timed;
    // Use this for initialization
    void Start () {
         timed = time;

    }
	
	// Update is called once per frame
	void Update () {
       
       timed -= Time.deltaTime;
       if (timed <= 0)
       {
            Vector3 carp = new Vector3(Random.Range(-4.23f, 4.47f), transform.position.y, transform.position.z);
            carno = Random.Range(0,8);
            
            Instantiate(cars[carno], carp, transform.rotation);
          timed = time;
        }
                
        
        
    }
}
