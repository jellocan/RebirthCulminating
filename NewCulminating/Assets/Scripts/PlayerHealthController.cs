using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour {
    public int MaxHealth;
    public int CurrentHealth;
	// Use this for initialization
	void Start () {
        CurrentHealth = MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (CurrentHealth < 0)
        {
            gameObject.SetActive(false);

        }
	}
    public void damageplayer(int damage)
    {
        CurrentHealth -= damage;
    }//creats a new function to able to be acalled upon
    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
