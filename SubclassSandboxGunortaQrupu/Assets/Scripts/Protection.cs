using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protection : MagicSpell
{
	[SerializeField] private GameObject[] particles;
	public override void Activate()
	{
		SpawnParticle();

		Effect();
	}

	public override void SpawnParticle()
	{
		base.SpawnParticle();

		foreach(GameObject particle in particles)
		{
			//SpawnParticles
		}
	}
}
