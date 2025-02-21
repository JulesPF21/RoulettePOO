using UnityEngine;

public class HeroManager
{
    [SerializeField] private int damageAmount;
    [SerializeField] private int wallDamageAmount;
    [SerializeField] private int healing;
    [SerializeField] private int wallHealing;
    [SerializeField] private int attackHeight;
    [SerializeField] private bool isHealer;
    [SerializeField] private bool isKnight;
    [SerializeField] private bool isMage;
    [SerializeField] private LevelManager levelManager;
    [SerializeField] private PlayerManager playerManager;

    virtual public void Attack()
    {
        if (isHealer)
        { 
            playerManager.heal(healing);
        }

        if (isKnight)
        {
            if (playerManager.wallHeight <= 0)
            {
                playerManager.damage(damageAmount);
            }

            if (playerManager.wallHeight > 0)
            { 
                playerManager.wallDamage(wallDamageAmount);
            }
        }

        if (isMage)
        {
            if (playerManager.wallHeight < attackHeight)
            { 
                playerManager.damage(damageAmount);
            }
            if (playerManager.wallHeight > attackHeight)
            {
                playerManager.wallDamage(wallDamageAmount);
            }
        }
    }
}
