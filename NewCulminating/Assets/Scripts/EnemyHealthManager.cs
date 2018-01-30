using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {
    public int EnemyMaxHealth;
    public int EnemyCurrentHealth;
    public GameObject enemy;
    // Use this for initialization
    void Start()
    {
        EnemyCurrentHealth = EnemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyCurrentHealth < 0)
        {
            Instantiate(enemy,new Vector3(Random.Range(-30,30), Random.Range(-20, 20), 0f), transform.rotation);
            Instantiate(enemy, new Vector3(Random.Range(-30, 30), Random.Range(-20, 20), 0f), transform.rotation);
            Destroy(gameObject);

        }
    }
    public void damageEnemy(int damage)
    {
        EnemyCurrentHealth -= damage;
    }//creats a new function to able to be acalled upon
    public void SetEnemyMaxHealth()
    {
        EnemyCurrentHealth = EnemyMaxHealth;
    }
}
