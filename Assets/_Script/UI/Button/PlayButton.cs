using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : BaseButton
{
    protected override void OnClick()
    {
        this.DisableGameObject(UICtrl.Instance.MainMenu);
        this.DisableGameObject(UICtrl.Instance.BirdSelectMenu);
    }
}
