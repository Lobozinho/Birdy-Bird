using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButMainMenu : BasePlayButton
{
    protected override void OnClick()
    {
        PlayerCtrl.Instance.PlayerAvatar.ShowAvatar();

        base.OnClick();
    }
}
