using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButBirdMenu : BaseButton
{
    protected override void OnClick()
    {
        this.DisableGameObject(UICtrl.Instance.BirdSelectMenu);
        PlayerCtrl.Instance.PlayerAvatar.ShowAvatar(UICtrl.Instance.BirdSelect.BirdCount);
    }
}
