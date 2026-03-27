using UnityEngine;

public class PowerUPBase : ItemCollectableBase
{
    [Header("Power Up")]
    public float duration;
    protected override void OnCollect()
    {
        base.OnCollect();
        StartPowerUp();
    }
    protected virtual void StartPowerUp()
    {
        Invoke(nameof(EndPowerUp), duration);


    }

    protected virtual void EndPowerUp()
    {


    }
}
