using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    //Health of Player
    public int maxHealth = 100;
    public int currentHealth;

    public Rigidbody2D rb2D;
    public float hitForce = 1f;

    public bool canTakeDamage = true;
    public float damageTimeout = 1f;

    public HealthBar healthBar;
    
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void OnCollisionEnter2D (Collision2D collisionInfo2D)
    {
        
        if (canTakeDamage && collisionInfo2D.collider.tag == "Enemy")
        {
            
            // Add force to bounce the player away from the enemy
            rb2D.AddForce(transform.up * hitForce, ForceMode2D.Impulse);
            // Take damage
            TakeDamage(25);
            //Start timer before player can take more damage
            StartCoroutine(damageTimer());
            
            if(currentHealth <= 0)
            {
                FindObjectOfType<GameManager>().EndGame();
            } 
            
            if(collisionInfo2D.collider.name == "Enemy")
            {
                //Playing sound effect for frog
                SoundManager.PlaySound ("eagleAttack"); 
            }
            else if(collisionInfo2D.collider.name == "Frog Enemy")
            {
                //Playing sound effect for frog     
                SoundManager.PlaySound ("frogAttack"); 
            }
        }
    }

    private IEnumerator damageTimer() 
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageTimeout);
        canTakeDamage = true;
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

}
