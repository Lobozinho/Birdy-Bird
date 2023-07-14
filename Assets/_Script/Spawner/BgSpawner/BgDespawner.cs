using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgDespawner : Despawner
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.offsetDespawn = 9;
    }

    protected override void Despawn()
    {
        SpawnerCtrl.Instance.BgSpawner.Despawn(transform.parent);
    }
}
