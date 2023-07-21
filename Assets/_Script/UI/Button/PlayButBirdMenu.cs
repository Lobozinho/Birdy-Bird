using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButBirdMenu : BasePlayButton
{
    protected override void OnClick()
    {
        base.OnClick();
        PlayerCtrl.Instance.PlayerAvatar.ShowAvatar(UICtrl.Instance.BirdSelect.BirdCount);
    }
}
