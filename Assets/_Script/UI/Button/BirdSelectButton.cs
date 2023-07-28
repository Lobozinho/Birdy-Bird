using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSelectButton : BaseButton
{
    protected override void OnClick()
    {
        this.DisableGameObject(transform.parent.gameObject);
        this.OnEnableGameObject(UICtrl.Instance.BirdSelectMenu.gameObject);
    }
}
