using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDespawn : Despawner
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.offsetDespawn = 3;
    }

    protected override void Despawn()
    {
        SpawnerCtrl.Instance.PipeSpawner.Despawn(transform.parent);
    }
}
