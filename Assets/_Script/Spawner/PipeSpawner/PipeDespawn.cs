using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDespawn : Despawner
{
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.offsetDespawn += 1;
    }

    protected override void Despawn()
    {
        SpawnerCtrl.Instance.PipeSpawner.Despawn(transform.parent);
    }
}
