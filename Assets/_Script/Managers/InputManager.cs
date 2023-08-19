using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : LoboMonoBehaviour
{
    [SerializeField] private bool _isJump;
    public bool IsJump { get => _isJump; }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) this._isJump = true;
        if (Input.GetMouseButtonUp(0)) this._isJump = false;
    }

}
