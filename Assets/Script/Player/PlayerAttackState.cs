using UnityEngine;


public class PlayerAttackState : PlayerBaseState
{
    public PlayerAttackState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        stateMachine.player.Shoot(stateMachine.player.data.target);
        StartAnimation(stateMachine.player.AnimationData.AttackParameterHash);
        //TODO : 화살 발사 (ObjectPool사용 하셔야겠지?)  + 애니메이션 설정
    }
    public override void Exit()
    {
        StopAnimation(stateMachine.player.AnimationData.AttackParameterHash);
    }
    public override void Update()
    {
        base.Update();
        //애니메이션이 끝날때까지 기다렸다가.(그 시간 다 지나고 넘어가는거 하면 될듯 ? Animator에서
        stateMachine.ChangeState(stateMachine.IdleState);
    }
}

