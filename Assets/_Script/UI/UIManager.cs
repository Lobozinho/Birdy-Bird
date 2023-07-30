using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void OnEnableGameOverMenu()
    {
        UICtrl.Instance.GameOverMenu.SetActive(true);
    }

    public void DisableGameOverMenu()
    {
        UICtrl.Instance.GameOverMenu.SetActive(false);
    }

    public void OnEnableScoreText()
    {
        UICtrl.Instance.ScoreText.SetActive(true);
    }

    public void DisableScoreText()
    {
        UICtrl.Instance.ScoreText.SetActive(false);
    }

    public void OnEnableMainMenu()
    {
        UICtrl.Instance.MainMenu.SetActive(true);
    }

    public void DisableMainMenu()
    {
        UICtrl.Instance.MainMenu.SetActive(false);
    }

}
