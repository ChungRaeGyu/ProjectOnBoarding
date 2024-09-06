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
        base.Update();
        if(time < stateMachine.monster.animationProgress)
        {
            time += Time.deltaTime;
            Debug.Log("실행");
        }
        else
        {
            if (Mathf.Approximately(GameManager.Instance.Player.transform.position.x + 1.5f, stateMachine.monster.transform.position.x))
            {
                stateMachine.ChangeState(stateMachine.IdleState);
            }
            else
            {
                stateMachine.ChangeState(stateMachine.WalkState);
            }
        }
        return;
    }
    public override void PhysicalUpdate()
    {
        
    }
}

