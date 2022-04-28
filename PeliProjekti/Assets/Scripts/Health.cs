using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    public int Respawn;

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
        if (curHealth <= 0)
        {
            Death();
        }

    }

    public void Death()
    {
        if (curHealth <= 0)
        {
            Destroy(gameObject);
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            DamagePlayer(30);
        }
        if (col.transform.name == "Deathzone")
        {
            DamagePlayer(50);
        }
        if (col.gameObject.CompareTag("InstaDeath"))
        {
            DamagePlayer(100);
        }
    }
}
