using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {
    public int EnemyMaxHealth;
    public int EnemyCurrentHealth;
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
