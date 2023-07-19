using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : LoboMonoBehaviour
{

    [SerializeField] private bool _pressSpace;
    public bool PressSpace { get => _pressSpace; }

    private void Update()
    {
        this._pressSpace = Input.GetButton("Jump");
    }
}
