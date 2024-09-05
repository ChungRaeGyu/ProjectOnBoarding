using UnityEngine;

public class MonsterIdleState : MonsterBaseState
{

    private bool isAttack = false;
    private float coolTime = 1f;
    private float time = 0;

    public MonsterIdleState(MonsterStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        time = 0;
        StartAnimation(stateMachine.monster.animationData.IdleParameterHash);
    }

    public override void Exit()
    {
        StopAnimation(stateMachine.monster.animationData.IdleParameterHash);
    }

    public override void PhysicalUpdate()
    {
        //base의 Move를 호출하지 않도록 한다.
    }
    public override void Update()
    {
        //공격 하기 뭐 쿨타임 도 주고 
        if (isAttack)
        {
            if (time < coolTime)
            {
                time += Time.deltaTime;
            }
            else
            {
                isAttack = false;
            }
        }
        else
        {
            stateMachine.ChangeState(stateMachine.AttackState);
            isAttack = true;
        }
    }
}
