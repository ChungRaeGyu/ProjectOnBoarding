

using UnityEngine;

public class MonsterAttackState : MonsterBaseState
{
    float time;
    public MonsterAttackState(MonsterStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        StartAnimation(stateMachine.monster.animationData.AttackParameterHash);
        time = 0;
    }
    public override void Exit()
    {
        StopAnimation(stateMachine.monster.animationData.AttackParameterHash);
    }

    public override void Update()
    {

        if (time < stateMachine.monster.animationProgress)
        {
            time += Time.deltaTime;
        }
        else
        {
            stateMachine.ChangeState(stateMachine.IdleState);
            Debug.Log("IdleState변경");
        }
        return;
    }
    public override void PhysicalUpdate()
    {

    }
}

