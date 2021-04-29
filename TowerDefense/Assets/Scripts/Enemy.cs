using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
   public float startSpeed = 10f;
   [HideInInspector]
   public float speed;

   public float startHealth = 100;
   public float health;

   public int Worth = 50;

   public GameObject deathEffect;

   [Header("Unity Stuff")]
   public Image healthBar;
   private Color healthBarColor;
   
   void Start(){
       speed = startSpeed;
       health = startHealth;
       healthBarColor = healthBar.color;
       healthBar.color = healthBarColor;
   }
   
   public void TakeDamage(float amount){
       health -= amount;

       healthBar.fillAmount = health / startHealth;

       if(health <= 50){
           healthBar.color = new Color(255f, 0f, 0f, 255f);
       }

       if(health <= 0){
           Die();
       }
   }

   public void Slow(float Pct){
        speed = startSpeed * (1f - Pct);
   }

   void Die(){
       PlayerStats.Money += Worth;

       GameObject effect =(GameObject) Instantiate(deathEffect,transform.position,Quaternion.identity);
       Destroy(effect,5f);

       WaveSpawner.EnemiesAlive--;
       
       Destroy(gameObject);
   }

}
