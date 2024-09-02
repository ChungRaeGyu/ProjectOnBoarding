public class PlayerStateMachine : StateMachine
{
    //���⼭ �÷��̾ ����� State�� ������ �־���Ѵ�. 
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

