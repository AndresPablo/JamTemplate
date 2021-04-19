using UnityEngine.Events;
using UnityEngine;

public class HealthHandler : MonoBehaviour, IDamageable
{
    [Min(1)]public float maxHealth = 100;
    [SerializeField]float health = 100;
    [SerializeField]GameObject deathPrefab;
    
    #region EVENTS
    public UnityEvent OnTakeDamage;
    public UnityEvent OnDeath;
    #endregion EVENTS
    
    protected virtual void Start() {
        health = maxHealth;
    }
    
    public virtual void TakeDamage(DamageData _data)
    {
        health -= _data.amount;
        if(health <= 0)
        {
            if(deathPrefab) Instantiate(deathPrefab, transform.position, transform.rotation);
            Kill();
        }
    }
    
    public virtual void  Kill()
    {
        DestroSelf();
    }
    
    public virtual void DestroSelf()
    {
        Destroy(gameObject);
    }
}
