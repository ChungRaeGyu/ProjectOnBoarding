using UnityEditor;

public class MonsterStateMachine : StateMachine
{
    public Monster monster;
    
    public MonsterIdleState IdleState { get; private set; }
    public MonsterWalkState WalkState { get; private set; }
    public MonsterAttackState AttackState { get; private set; }
    public MonsterHurtState HurtState { get; private set; }
    public MonsterDeathState DeathState { get; private set; }
    public MonsterStateMachine(Monster monster)
    {
        this.monster = monster;
        IdleState = new MonsterIdleState(this);
        WalkState = new MonsterWalkState(this);
        AttackState = new MonsterAttackState(this);
        HurtState = new MonsterHurtState(this);
        DeathState = new MonsterDeathState(this);

    }
    //몬스터에서 사용할 statemachine종류 들고있
}
