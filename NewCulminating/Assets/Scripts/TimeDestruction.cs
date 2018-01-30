using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestruction : MonoBehaviour {
    public float destroytime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        destroytime -= Time.deltaTime;
        if(destroytime <= 0)
        {
            Destroy(gameObject);
        }
	}
}
