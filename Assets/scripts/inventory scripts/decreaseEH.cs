using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decreaseEH : MonoBehaviour
{
    public Vector3 damage;

    public void OnMouseDown()
    {
        var healthBar = GameObject.Find("health bar");
        GameObject enemy = GameObject.Find("enemy");

        //gets a refernece to the enemy controller script

        var enemyScript = enemy.GetComponent<enemyController>();

        //reduces the size of the healthbar when item is used

        healthBar.transform.localScale = healthBar.transform.localScale - damage;

        //reduces enemy health when item is used

        enemyScript.health = enemyScript.health - 20;

        //destroys item after use

        Destroy(gameObject);
    }
}
