using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExPlayer : MonoBehaviour
{
    private int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Debug.Log("����Ͽ����ϴ�");
    }
}
    // Start is called before the first frame update
