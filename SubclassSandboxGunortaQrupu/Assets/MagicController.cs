using UnityEngine;
using UnityEngine.UI;

public class MagicController : MonoBehaviour
{
	[SerializeField] private GameObject[] spellPrefabs;

	[SerializeField] private Button[] spellButtons;

	[SerializeField] private Animator charAnimatorRef;

	[SerializeField] private Transform charTargetRef;

	[SerializeField] private Transform enemyTargetRef;

	private void Start()
	{
		for (int i = 0; i < spellPrefabs.Length; i++)
		{
			GameObject spellInstance = Instantiate(spellPrefabs[i], transform);

			MagicSpell spell = spellInstance.GetComponent<MagicSpell>();

			Transform targetRef;

			if (spell.IsEnemySpell)
			{
				targetRef = enemyTargetRef;
			}
			else
			{
				targetRef = charTargetRef;
			}

			spell.SetupSpell(charAnimatorRef, targetRef);

			spellButtons[i].onClick.AddListener(delegate { OnSpellButtonPressed(spell); });

			
		}
	}

	private void OnSpellButtonPressed(MagicSpell spell)
	{
		spell.Activate();
	}

}
