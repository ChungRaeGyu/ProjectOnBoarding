using UnityEngine;

public class MonsterHurtState : MonsterBaseState
{
    float time;
    public MonsterHurtState(MonsterStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        StartAnimation(stateMachine.monster.animationData.HurtParameterHash);
        time = 0;
    }
    public override void Exit()
    {
        StopAnimation(stateMachine.monster.animationData.HurtParameterHash);
    }
    public override void Update()
    {
        if(time < stateMachine.monster.animationProgress)
        {
            time += Time.deltaTime;
            Debug.Log("실행");
        }
        else
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

