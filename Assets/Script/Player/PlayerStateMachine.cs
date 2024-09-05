public class PlayerStateMachine : StateMachine
{
    //여기서 플레이어가 사용할 State를 가지고 있어야한다. 
    public Player player;

    public PlayerIdleState IdleState { get; private set; }
    public PlayerAttackState AttackState { get; private set; }
    public PlayerStateMachine(Player player)
    {
        this.player = player;
        IdleState = new PlayerIdleState(this);
        AttackState = new PlayerAttackState(this);
    }
}

