using UnityEngine;

public class MonsterDeathState : MonsterBaseState
{
    public MonsterDeathState(MonsterStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        StartAnimation(stateMachine.monster.animationData.DieParameterHash);
        Debug.Log("Enter : " + stateMachine.monster.animationProgress);

    }
    public override void Exit()
    {
        StopAnimation(stateMachine.monster.animationData.DieParameterHash);
    }

    public override void Update()
    {
        Debug.Log(stateMachine.monster.animationProgress);
        if (stateMachine.monster.animationProgress >= 1)
        {
            stateMachine.monster.DieAction();
            Debug.Log("죽음");
        }
        return;
    }
    public override void PhysicalUpdate()
    {
        
    }
}
