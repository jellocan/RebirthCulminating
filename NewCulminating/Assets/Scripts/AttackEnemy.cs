using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour {
    public int damagegive;
    public GameObject DamageBurst;
    public Transform hitPoint;
    public GameObject damageNumber;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {



    }
    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.gameObject.tag == "Enemy")
    {
            other.gameObject.GetComponent<EnemyHealthManager>().damageEnemy(damagegive);
            Instantiate(DamageBurst, hitPoint.position, hitPoint.rotation);
            var clone =(GameObject) Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero));///create a clone of DamageNumbers so we can modify the damage 
            clone.GetComponent<FloatingNumbers>().damageNumber = damagegive;//import variable so we can change
        }
   }
}




