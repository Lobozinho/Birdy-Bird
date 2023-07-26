using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayButton : BaseButton
{
    protected override void OnClick()
    {
        this.DisableGameObject(transform.parent.gameObject);
        PlayerCtrl.Instance.PlayerAnimation.GetAnimation();
        ManagersCtrl.Instance.InputManager.gameObject.SetActive(true);
        UICtrl.Instance.ScoreText.SetActive(true);
    }
}
