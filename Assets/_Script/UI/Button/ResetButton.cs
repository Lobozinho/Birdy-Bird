using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : BaseButton
{
    protected override void OnClick()
    {
        this.DisableGameObject(transform.parent.parent.gameObject);
        ManagersCtrl.Instance.GameManager.ResetGame();
    }
}
