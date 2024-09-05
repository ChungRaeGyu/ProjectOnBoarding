public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        base.Enter();
        StartAnimation(stateMachine.player.AnimationData.IdleParameterHash);
    }
    public override void Exit()
    {
        StopAnimation(stateMachine.player.AnimationData.IdleParameterHash);
    }
}

