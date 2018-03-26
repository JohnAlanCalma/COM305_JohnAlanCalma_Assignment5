using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public float weaponDamage = 5.0f;
    public Transform attackCheck;
    public float attackCheckRadius = 0.2f;
    public LayerMask defineAttack;

    private Animator animator;
    private bool isAttacking = false;
    private Collider2D col2D;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
     
            col2D = Physics2D.OverlapCircle(attackCheck.position, attackCheckRadius, defineAttack);

            if(col2D != null && col2D.tag.StartsWith("Enemy"))
            {
                Debug.Log("Enemy hit");
                // Do some damage to the enemy.
                col2D.GetComponent<EnemyHealth>().Damage(weaponDamage);
            }
        
	}
    
    public void ResetAttackBool()
    {
        isAttacking = false;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(attackCheck.position, attackCheckRadius);
    }
}
