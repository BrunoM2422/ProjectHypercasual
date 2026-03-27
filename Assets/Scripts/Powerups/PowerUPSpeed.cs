using UnityEngine;
using static PlayerScript;


public class PowerUPSpeed : PowerUPBase
{
    [Header("Power Up Speed Up")]
    public float amountToSpeed;
    protected override void StartPowerUp()
    {
        PlayerScript.Instance.ApplyPowerUp(PowerUpType.Speed, duration, amountToSpeed);
    }

}
