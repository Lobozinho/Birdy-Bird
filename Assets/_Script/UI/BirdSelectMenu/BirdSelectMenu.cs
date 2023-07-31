using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSelectMenu : LoboMonoBehaviour
{
    [SerializeField] private BirdList _birdList;
    public BirdList BirdList => _birdList;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBirdList();
    }

    void LoadBirdList()
    {
        if (this._birdList != null) return;
        this._birdList = GetComponentInChildren<BirdList>();
        Debug.LogWarning(transform.name + ": LoadBirdList", gameObject);
    }

}
