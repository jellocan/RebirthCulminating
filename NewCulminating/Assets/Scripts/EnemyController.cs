using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameObject Player;
    public float moveSpeed;
    private Vector3 PlayerPos;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);//set the postion to go to
        transform.position = Vector3.Lerp(transform.position, PlayerPos, moveSpeed * Time.deltaTime);//move towards target pos at the interval
    }
}
