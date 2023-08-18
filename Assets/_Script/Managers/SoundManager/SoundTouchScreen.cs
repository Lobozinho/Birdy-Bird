using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTouchScreen : BaseSound
{

    private void Update()
    {
        this.PlaySoundTouchScreen();
        //this.MuteSoundTouchScreen();
    }

    void PlaySoundTouchScreen()
    {
        if (!this.IsPressJump()) return;
        this.audioSource.Play();
    }

    void MuteSoundTouchScreen()
    {
        if(this.IsPressJump()) return;
        this.audioSource.Stop();
    }

    bool IsPressJump()
    {
        return ManagersCtrl.Instance.InputManager.IsJump;
    }

}
