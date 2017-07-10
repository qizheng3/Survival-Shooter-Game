using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthScoreManager : MonoBehaviour 
{
	public PlayerHealth playerHealth;
	public Text reftext;

	void Awake ()
	{
		reftext = GetComponent <Text> ();
	}

	void Update ()
	{
		reftext.text = "Health Level:  " + playerHealth.currentHealth;
		if (playerHealth.currentHealth <= 30) {
			reftext.color = Color.red;
		}
		else if (playerHealth.currentHealth <= 60) {
			reftext.color = Color.yellow;
		}
	}
}
