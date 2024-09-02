using UnityEngine;

public class Monster : MonoBehaviour
{
    private int health = 100;

    public void TakeDamage()
    {
        health -= 100;
    }
}

