using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButBirdMenu : BasePlayButton
{
    protected override void OnClick()
    {
        PlayerCtrl.Instance.PlayerAvatar.ShowAvatar(UICtrl.Instance.BirdSelect.BirdCount);
        base.OnClick();
    }
}
