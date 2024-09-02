using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public GameObject Arrow;
    [field : SerializeField]public PlayerAnimationData AnimationData { get; private set; }
    public PlayerStateMachine stateMachine;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        AnimationData.Initialize();
        stateMachine = new PlayerStateMachine(this);
        stateMachine.ChangeState(stateMachine.IdleState);
    }

    private void Update()
    {
        stateMachine?.Update(); 
    }

    public void Shoot()
    {
        Debug.Log("발사");
        //Resources.Load<GameObject>("Prefabs/Arrow");
        Instantiate(Arrow);
    }
}
