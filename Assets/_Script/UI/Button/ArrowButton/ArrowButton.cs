using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowButton : BaseButton
{
    [SerializeField] protected BirdList birdSelect;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBirdSelect();
    }

    void LoadBirdSelect()
    {
        if (this.birdSelect != null) return;
        this.birdSelect = transform.parent.GetComponentInChildren<BirdList>();
        Debug.LogWarning(transform.name + ": LoadBirdSelect", gameObject);
    }

    protected override void OnClick()
    {
        
    }
}
