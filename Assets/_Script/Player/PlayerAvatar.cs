using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : LoboMonoBehaviour
{
    [SerializeField] private List<Transform> _avatars;
    public List<Transform> Avatars => _avatars;

    [SerializeField] private bool _isShow = false;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAvatars();
    }

    void LoadAvatars()
    {
        if (this._avatars.Count > 0) return;

        foreach (Transform avatar in transform)
        {
            this._avatars.Add(avatar);
            avatar.gameObject.SetActive(false);
        }
    }

    public void ShowAvatar(int index = 0)
    {
        if (this._isShow) return;
        this._avatars[index].gameObject.SetActive(true);
        this._isShow = true;
    }

}
