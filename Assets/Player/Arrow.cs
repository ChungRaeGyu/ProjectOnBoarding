using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private float speed;

    private void Update()
    {
        Debug.Log("실행");
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, target.transform.position, speed);
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
