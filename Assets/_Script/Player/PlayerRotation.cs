using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private float _rotationDecrease = 0.03f;
    [SerializeField] private float _timeLimit = 0.25f;
    private float _timeDelay = 0;

    private void FixedUpdate()
    {
        this.CountTime();
        this.UpdateRotation();
    }

    void CountTime()
    {
        if (!this.IsStartLevel()) return;
        if (this.IsPressSpace())
        {
            this._timeDelay = 0;
            return;
        }
        this._timeDelay += Time.fixedDeltaTime;
    }

    void UpdateRotation()
    {
        if (!this.IsStartLevel()) return;
        this.Rotating();
        this.SetRotationZero();
    }

    void Rotating()
    {
        if (this._timeDelay < this._timeLimit) return;

        float playerRotationZ = PlayerCtrl.Instance.transform.rotation.z;
        playerRotationZ -= this._rotationDecrease;
        
        float playerRotationW = PlayerCtrl.Instance.transform.rotation.w;

        PlayerCtrl.Instance.transform.rotation = new Quaternion(0, 0, playerRotationZ, playerRotationW);
    }

    void SetRotationZero()
    {
        if (!this.IsPressSpace()) return;
        PlayerCtrl.Instance.transform.rotation = quaternion.identity;
    }

    bool IsPressSpace()
    {
        return ManagersCtrl.Instance.InputManager.IsJump;
    }

    bool IsStartLevel()
    {
        return ManagersCtrl.Instance.GameManager.LevelStart;
    }

}
