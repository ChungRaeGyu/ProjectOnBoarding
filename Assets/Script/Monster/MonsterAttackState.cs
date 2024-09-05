

using UnityEngine;

public class MonsterAttackState : MonsterBaseState
{
    public MonsterAttackState(MonsterStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        StartAnimation(stateMachine.monster.animationData.AttackParameterHash);
    }
    public override void Exit()
    {
        StopAnimation(stateMachine.monster.animationData.AttackParameterHash);
    }

    public override void Update()
    {
        base.Update();
        Debug.Log(stateMachine.monster.animationProgress);
        if (stateMachine.monster.animationProgress >= 1)
        {
            //stateMachine.ChangeState(stateMachine.IdleState);
            Debug.Log("IdleState변경");
        }
        return;
    }
    public override void PhysicalUpdate()
    {

    }
}

