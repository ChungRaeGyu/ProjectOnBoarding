public interface IState
{
    public void Enter();
    public void Exit();
    public void Update();
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
    // Start is called before the first frame update
    
}
