using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSpell : MonoBehaviour
{
  [SerializeField] private string spellStringID;

  [SerializeField] private AudioSource spellSFXSource;

  [SerializeField] private AudioClip spellSFX;

  [SerializeField] private GameObject spellVFX;

  public bool IsEnemySpell;

  private Animator characterAnimator;

  private Transform target;

  public virtual void Activate()
	{
    SpawnParticle();

    PlayAnimation();

    PlaySound();

    Effect();
	}

  public virtual void SpawnParticle()
	{
    GameObject particleInstance = Instantiate(spellVFX, target);

    particleInstance.GetComponent<ParticleSystem>().Play();
	}

  public virtual void PlaySound()
	{
    spellSFXSource.clip = spellSFX;

    spellSFXSource.Play();
	}

  public virtual void PlayAnimation()
	{
    characterAnimator.Play(spellStringID);
	}

  public virtual void Effect()
	{
    Debug.Log(spellStringID + " applied");
	}

  public void SetupSpell(Animator _charAnimator, Transform _targetRef)
	{
    characterAnimator = _charAnimator;

    target = _targetRef;
	}
}
