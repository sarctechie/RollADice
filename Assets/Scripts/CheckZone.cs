using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckZone : MonoBehaviour
{
    Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity = Dice.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
			switch (col.gameObject.name) {
			case "Side1":
				DiceText.diceNumber = 6;
				break;
			case "Side2":
				DiceText.diceNumber = 5;
				break;
			case "Side3":
				DiceText.diceNumber = 4;
				break;
			case "Side4":
				DiceText.diceNumber = 3;
				break;
			case "Side5":
				DiceText.diceNumber = 2;
				break;
			case "Side6":
				DiceText.diceNumber = 1;
				break;
			}
		}
	}
}
