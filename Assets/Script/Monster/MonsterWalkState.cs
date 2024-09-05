using UnityEngine;

public class MonsterWalkState : MonsterBaseState
{
    public MonsterWalkState(MonsterStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        StartAnimation(stateMachine.monster.animationData.WalkParameterHash);
    }
    public override void Exit()
    {
        StopAnimation(stateMachine.monster.animationData.WalkParameterHash);
    }

    public override void Update()
    {
        base.Update();
        if (Mathf.Approximately(GameManager.Instance.Player.transform.position.x + 1.5f, stateMachine.monster.transform.position.x))
        {
            stateMachine.ChangeState(stateMachine.IdleState);
            return;
        }
    }

}

