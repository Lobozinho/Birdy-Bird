using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoardButton : BaseButton
{
    protected override void OnClick()
    {
        this.DisableGameObject(UICtrl.Instance.MainMenu);
        this.OnEnableGameObject(UICtrl.Instance.LeaderBoardMenu.gameObject);
    }
}
