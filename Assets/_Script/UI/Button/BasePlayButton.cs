using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayButton : BaseButton
{
    protected override void OnClick()
    {
        this.DisableGameObject(transform.parent.gameObject);
        ManagersCtrl.Instance.GameManager.GameStarted();
        PlayerCtrl.Instance.PlayerAnimation.GetAnimation();
    }
}
