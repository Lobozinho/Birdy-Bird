using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButBirdMenu : BasePlayButton
{
    protected override void OnClick()
    {
        GameManager gameManager = ManagersCtrl.Instance.GameManager;
        if (gameManager.LevelStart)
        {
            ManagersCtrl.Instance.PlayerPrefsManager.SaveBirdCount();
            gameManager.ResetGame();
            return;
        }
        
        PlayerCtrl.Instance.PlayerAvatar.ShowAvatar(UICtrl.Instance.BirdSelectMenu.BirdList.BirdCount);
        base.OnClick();
    }
}
