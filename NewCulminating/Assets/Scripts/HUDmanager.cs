using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDmanager : MonoBehaviour {
    public Slider healthBar;
    public Text HPText;
    public PlayerHealthController playerHealth;
    public Text ScoreV;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.maxValue = playerHealth.MaxHealth;
        healthBar.value = playerHealth.CurrentHealth;
        HPText.text = "HP: " + playerHealth.CurrentHealth + "/" + playerHealth.MaxHealth;
        ScoreV.text = "HP: " + playerHealth.CurrentHealth + "/" + playerHealth.MaxHealth;
    }
}
