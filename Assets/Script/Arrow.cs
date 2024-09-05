using System;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private float speed;


    public void SetTarget(GameObject obj)
    {
        target = obj;
    }

    private void Update()
    {
        if(target != null)
            gameObject.transform.position = Vector2.MoveTowards(
                gameObject.transform.position, 
                target.transform.position, 
                speed*Time.deltaTime);
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            collision.GetComponent<Monster>().TakeDamage();
            Destroy(gameObject); //ObjectPool로 변환 하기 
        }
    }
}
[CreateAssetMenu(fileName = "EnemySO",menuName = "SO/EnemySO")]
public class EnemySO : ScriptableObject
{
    public string Name;
    public int Grade;
    public int Speed;
    public int Health;
}
