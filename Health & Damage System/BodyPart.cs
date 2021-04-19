using UnityEngine;

public class EnemyPart : MonoBehaviour, IDamageable
{
    [Range(0,2f)]
    [SerializeField]float damageMultiplier = 1;
    

    public void TakeDamage(DamageData damageData)
    {
        damageData.amount *= damageMultiplier;
        GetComponentInParent<Enemy>().TakeDamage(damageData);
     }
     
}
    
