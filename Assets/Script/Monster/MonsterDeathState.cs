using UnityEngine;

public class MonsterDeathState : MonsterBaseState
{
    float time;
    bool die;
    public MonsterDeathState(MonsterStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        time = 0;
        StartAnimation(stateMachine.monster.animationData.DieParameterHash);

    }
    public override void Exit()
    {
        StopAnimation(stateMachine.monster.animationData.DieParameterHash);
    }

    public override void Update()
    {
        if (!die)
        {
            if (time < stateMachine.monster.animationProgress)
            {
                time +=Time.deltaTime;
            }
            else
            {
                stateMachine.monster.DieAction();
                die = true;
                Debug.Log("죽음");
            }
        }
        return;
    }
    public override void PhysicalUpdate()
    {
        
    }
}
