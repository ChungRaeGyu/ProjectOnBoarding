using UnityEngine;

public class MonsterBaseState : IState
{
    public MonsterStateMachine stateMachine;

    public MonsterBaseState(MonsterStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter()
    {
    }

    public virtual void Exit()
    {

    }

    public virtual void Update()
    {

    }
    public virtual void PhysicalUpdate()
    {
        //움직임 구현하기
        Move();
    }

    private void Move()
    {
        Vector2 target = new Vector2(GameManager.Instance.Player.transform.position.x+1.5f, GameManager.Instance.Player.transform.position.y); ;
        stateMachine.monster.transform.position = Vector2.MoveTowards(
            stateMachine.monster.transform.position,
            target,
            stateMachine.monster.data.speed*Time.deltaTime
            );


    }

    protected void StartAnimation(int hash)
    {
        stateMachine.monster.animator.SetBool(hash, true);
        AnimatorStateInfo info = stateMachine.monster.animator.GetCurrentAnimatorStateInfo(0);
        stateMachine.monster.animationProgress = info.normalizedTime;
    }
    protected void StopAnimation(int hash)
    {
        stateMachine.monster.animator.SetBool(hash, false);

    }

    private void TakeDamage()
    {
        if (stateMachine.monster.data.health <= 0)
        {
            stateMachine.ChangeState(stateMachine.DeathState);
        }
        else
        {
            stateMachine.ChangeState(stateMachine.HurtState);
        }
        return;
    }
}

