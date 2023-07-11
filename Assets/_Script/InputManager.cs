using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : LoboMonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance { get => _instance; }

    [SerializeField] private bool _pressSpace;
    public bool PressSpace { get => _pressSpace; }

    protected override void Awake()
    {
        if (InputManager._instance != null) Debug.LogError("only 1 InputManager allow to exist");
        InputManager._instance = this;
    }

    private void Update()
    {
        this._pressSpace = Input.GetButtonDown("Jump");
    }
}
