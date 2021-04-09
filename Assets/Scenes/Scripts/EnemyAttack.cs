using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;
    
    
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        print(target);
    }

    public void AttackHitEvent()
    {
        print(target);
        if (target == null) return;
        target.TakeDamage(damage);
        print("bang bang");
    }
}
