using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void DamagePlayer(int damage)
    {
        curHealth -= damage;

        healthBar.SetHealth(curHealth);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.name == "Enemy")
        {
            DamagePlayer(30);
        }
        if (col.transform.name == "Deathzone")
        {
            DamagePlayer(50);
        }
    }
}