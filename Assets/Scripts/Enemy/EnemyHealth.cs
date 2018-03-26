using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class EnemyHealthData
{
    public float maxHealth;
    public Slider healthBar;
}

[System.Serializable]
public class EnemyScoreData
{
    public int scoreValue = 1;
    public ScoreController scoreCont;
}

public class EnemyHealth : MonoBehaviour {

    /*
    public float maxHealth;
    public Slider healthBar;
    */
    public EnemyHealthData enemyHealthData;
    public EnemyScoreData enemyScoreData;
    /*
    public int scoreValue = 10;
    public ScoreController scoreCont;
    */

    private float currentHealth;


    // Define scoring

    // Use this for initialization
    void Start () {
        currentHealth = enemyHealthData.maxHealth;
	}
	
	public void Damage(float damageAmt)
    {
        currentHealth -= damageAmt;
        // currentHealth = currentHealh - damageAmt;
        UpdateHealth();
    }

    void UpdateHealth()
    {
        if(currentHealth <= 0)
        {
            Die();
        }

       // enemyHealthData.healthBar.value = currentHealth / enemyHealthData.maxHealth;
    }

    void Die()
    {
        switch (gameObject.tag)
        {
            case "Enemy1":
                enemyScoreData.scoreCont.UpdateScore(1, enemyScoreData.scoreValue);
                break;
            case "Enemy2":
                enemyScoreData.scoreCont.UpdateScore(2, enemyScoreData.scoreValue);
                break;
            case "Enemy3":
                enemyScoreData.scoreCont.UpdateScore(3, enemyScoreData.scoreValue);
                break;
        }
        enemyScoreData.scoreCont.UpdateScore(0, enemyScoreData.scoreValue);
        Destroy(this.gameObject);
    }
}
