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

    private void Awake()
    {
        stateMachine = new MonsterStateMachine(this);
        animationData.Initialize();
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        stateMachine.ChangeState(stateMachine.WalkState);
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
            stateMachine.ChangeState(stateMachine.HurtState);
        }
    }

    public void DieAction()
    {
        Destroy(gameObject);
    }

}
