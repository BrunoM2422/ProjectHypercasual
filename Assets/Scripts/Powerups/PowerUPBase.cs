using UnityEngine;
using DG.Tweening;

public class PowerUPBase : ItemCollectableBase
{

    private Transform player;

    [Header("Power Up")]
    public float duration;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    protected override void OnCollect()
    {
        base.OnCollect();
        player.transform.DOScale(1.2f , .1f).SetEase(Ease.OutBack);

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
