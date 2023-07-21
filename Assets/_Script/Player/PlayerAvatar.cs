using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : LoboMonoBehaviour
{
    [SerializeField] private List<Transform> _avatars;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAvatars();
    }

    void LoadAvatars()
    {
        foreach(Transform avatar in transform)
        {
            this._avatars.Add(avatar);
            avatar.gameObject.SetActive(false);
        }
    }

    public void ShowAvatar(int index)
    {
        this._avatars[index].gameObject.SetActive(true);
    }

}
