public interface IState
{
    public void Enter();
    public void Exit();
    public void Update();

    public void PhysicalUpdate();
}
public abstract class StateMachine
{
    public IState currentState;

    public void ChangeState(IState state)
    {
        currentState?.Exit();
        currentState = state;
        currentState.Enter();
    }
    public void Update()
    {
        currentState?.Update();
    }

    public void PhysicalUpdate()
    {
        currentState?.PhysicalUpdate();
    }
    // Start is called before the first frame update
    
}
