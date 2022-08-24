using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MagicSpell
{
	[SerializeField] private float healValue;
	public override void Activate()
	{
		PlayAnimation();

		SpawnParticle();

		HealPlayer();
		Debug.Log("Heal activated");

	}

	public virtual void HealPlayer()
	{
		print("Player healed : " + healValue);
	}

}
