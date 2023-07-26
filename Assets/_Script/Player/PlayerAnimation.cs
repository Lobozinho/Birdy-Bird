using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

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
    }

}
