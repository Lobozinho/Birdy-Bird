using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButMainMenu : BasePlayButton
{
    protected override void OnClick()
    {
        base.OnClick();
        PlayerCtrl.Instance.PlayerAvatar.ShowAvatar();
    }
}
