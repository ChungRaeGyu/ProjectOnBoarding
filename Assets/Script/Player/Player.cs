using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public GameObject Arrow;
    public Data data;
    [field : SerializeField]public PlayerAnimationData AnimationData { get; private set; }
    public PlayerStateMachine stateMachine;
    private void Awake()
    {
        GameManager.Instance.Player = this.gameObject;
        animator = GetComponent<Animator>();
        AnimationData.Initialize();
        stateMachine = new PlayerStateMachine(this);
        data = new Data();
        stateMachine.ChangeState(stateMachine.IdleState);
    }

    private void Update()
    {
        stateMachine?.Update(); 
    }

    public void Shoot(GameObject monster)
    {
        //Resources.Load<GameObject>("Prefabs/Arrow");
        GameObject arrow = Instantiate(Arrow);
        Vector2 spawnPos = new Vector2(transform.position.x+1, transform.position.y+1);
        arrow.transform.position = spawnPos;
        arrow.GetComponent<Arrow>().SetTarget(monster);
    }
}
