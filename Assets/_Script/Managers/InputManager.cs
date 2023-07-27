using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : LoboMonoBehaviour
{
    [SerializeField] private bool _pressJump;
    public bool PressSpace { get => _pressJump; }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) this._pressJump = true;
        if (Input.GetMouseButtonUp(0)) this._pressJump = false;
    }

}
