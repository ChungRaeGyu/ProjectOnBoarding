using System;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public MonsterData data;

    public MonsterAnimationData animationData;

    public MonsterStateMachine stateMachine;

    public Animator animator;

    public Rigidbody2D rigid;

    public float animationProgress;

    public bool endAnimation;

    private void Awake()
    {
        stateMachine = new MonsterStateMachine(this);
        animationData.Initialize();
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        stateMachine.ChangeState(stateMachine.WalkState);
        GameManager.Instance.currentMonster = this;
    }

    private void Update()
    {
        stateMachine?.Update();
    }
    private void FixedUpdate()
    {
        stateMachine?.PhysicalUpdate();
    }
    public void TakeDamage()
    {
        data.health -= 1;
        if (data.health <= 0)
        {
            stateMachine.ChangeState(stateMachine.DeathState);
        }
        else
        {
            if(stateMachine.currentState!=stateMachine.AttackState)
                stateMachine.ChangeState(stateMachine.HurtState);
        }
    }

    public void DieAction()
    {
        Debug.Log("DieAction");
        Destroy(gameObject);
        MonsterSpawner.Instance.Spawn();
    }

    private void OnMouseDown()
    {
        GameManager.Instance.OpenPanel();
    }
}
