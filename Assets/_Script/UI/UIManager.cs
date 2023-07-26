using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void OnEnableGameOverMenu()
    {
        UICtrl.Instance.GameOverMenu.SetActive(true);
    }
}
