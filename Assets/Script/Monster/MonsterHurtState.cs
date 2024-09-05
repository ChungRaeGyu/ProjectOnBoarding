using UnityEngine;

public class MonsterHurtState : MonsterBaseState
{
    public MonsterHurtState(MonsterStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        StartAnimation(stateMachine.monster.animationData.HurtParameterHash);
    }
    public override void Exit()
    {
        StopAnimation(stateMachine.monster.animationData.HurtParameterHash);
    }
    public override void Update()
    {
        if (stateMachine.monster.animationProgress >= 1)
        {
            stateMachine.ChangeState(stateMachine.WalkState);
            Debug.Log("WalkState");
        }
        return;
    }
    public override void PhysicalUpdate()
    {
        
    }
}

