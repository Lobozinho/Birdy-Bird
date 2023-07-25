using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    //[SerializeField] private bool _isDoneAnimationDead = false;

    public void GetAnimation()
    {
        foreach(Transform avatar in PlayerCtrl.Instance.PlayerAvatar.Avatars)
        {
            if (!avatar.gameObject.activeSelf) continue;
            this._animator = avatar.GetComponent<Animator>();
        }
    }

    public void SetAnimaitonDead()
    {
        this._animator.SetBool("isDead", true);
        //StartCoroutine(CheckAnimationComplete());
    }



    IEnumerator CheckAnimationComplete()
    {
        while (true)
        {
            if (!this._animator.IsInTransition(0))
            {
                break;
            }

            yield return null;
        }

        Debug.Log("Animation completed!");
    }

}
