using UnityEngine;

public class PlayerManager
{
    public int wallHeight;
    [SerializeField] private int playerHealth;
    [SerializeField] private HeroManager heroManager;


    public void heal(int healAmount)
    {
        playerHealth += healAmount;
    }

    public void damage(int damageAmount)
    {
        playerHealth -= damageAmount;
    }

    public void wallHeal(int wallHealAmount)
    {
        wallHeight += wallHealAmount;
    }

    public void wallDamage(int wallDamageAmount)
    {
        wallHeight -= wallDamageAmount;
    }
}
