using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Image bar;
    private float maxHealth;
    // Start is called before the first frame update
    private void OnEnable()
    {
        maxHealth = GameManager.Instance.currentMonster.data.health;
        Debug.Log("����");
        ;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.currentMonster != null)
        {
            float currentHealth = GameManager.Instance.currentMonster.data.health;
            bar.fillAmount = currentHealth / maxHealth;
            Vector2 pos = new Vector2(GameManager.Instance.currentMonster.transform.position.x, GameManager.Instance.currentMonster.transform.position.y + 1.5f);
            transform.position = pos;
        }
        if (GameManager.Instance.currentMonster.data.health <= 0)
        {
            gameObject.SetActive(false);
            Debug.Log("����");
        }
    }
    
}
