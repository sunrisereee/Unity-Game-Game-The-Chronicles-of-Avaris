using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int maxHP = 100;
    [SerializeField] int currentHP;
    void Start()
    {
        currentHP = maxHP;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0) Die();
    }

    void Die()
    {
        Debug.Log("Enemy Die");
        Destroy(gameObject);
    }
}
