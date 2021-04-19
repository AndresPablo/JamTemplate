using UnityEngine;

public struct DamageData
{
    public float amount;
    public bool critical;
    public DamageType type; 
    //public ContactPoint2D contact;
    //public float pushForce;
    //public Vector2 pushDirection;
}

public enum DamageType { CUT, STAB, CRUSH }
