using UnityEngine;

public class MonsterDeathState : MonsterBaseState
{
    float time;
    public MonsterDeathState(MonsterStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        time = 0;
        StartAnimation(stateMachine.monster.animationData.DieParameterHash);
        Debug.Log("Enter : " + stateMachine.monster.animationProgress);

    }
    public override void Exit()
    {
        StopAnimation(stateMachine.monster.animationData.DieParameterHash);
    }

    public override void Update()
    {
        if (time < stateMachine.monster.animationProgress)
        {
            time +=Time.deltaTime;
        }
        else
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
