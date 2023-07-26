using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrButLeaderBoardMenu : BaseButton
{
    protected override void OnClick()
    {
        this.DisableGameObject(transform.parent.gameObject);
        this.OnEnableGameObject(UICtrl.Instance.MainMenu);
    }
}
