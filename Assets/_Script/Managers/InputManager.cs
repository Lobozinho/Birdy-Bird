using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : LoboMonoBehaviour
{

    [SerializeField] private bool _pressSpace;
    public bool PressSpace { get => _pressSpace; }

    private void Update()
    {
        if (!this.IsGameStarted()) return;
        this._pressSpace = Input.GetButton("Jump");
    }

    bool IsGameStarted()
    {
        return ManagersCtrl.Instance.GameManager.GameStart;
    }

}
