using UnityEngine;

public class PlayerBaseState : IState
{
    protected PlayerStateMachine stateMachine;
    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    public float coolTime = 1f;
    private float time = 0;
    public virtual void Enter()
    {
        time = 0;
    }

    public virtual void Exit()
    {
        
    }

    public virtual void Update()
    {
        //TODO:몬스터가 사정거리 안에 들어왔는지 체크하고 무조건 타이머가 흘러가는게 아니라 발사 후 흘러가도록 수정
        if (time < coolTime)
        {
            time += Time.deltaTime;
        }
        else
        {
            //공격으로 전환
            stateMachine.ChangeState(stateMachine.AttackState);
        }
    }

    protected void StartAnimation(int hash)
    {
        stateMachine.player.animator.SetBool(hash, true);
    }
    protected void StopAnimation(int hash)
    {
        stateMachine.player.animator.SetBool(hash, false);

    }
}

