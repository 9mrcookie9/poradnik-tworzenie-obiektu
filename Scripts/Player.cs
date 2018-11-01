using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public Text CoinsText;
	public int Coins;

	private void Start() {
		DrawText();
	}

	private void DrawText() {
		CoinsText.text = "Monety: " + Coins;
	}

	private void OnCollisionEnter(Collision other) {
		if (other.transform.name == "Coin") {
			Coins++;
			DrawText();
			Destroy(other.gameObject);
		}
	}
}
