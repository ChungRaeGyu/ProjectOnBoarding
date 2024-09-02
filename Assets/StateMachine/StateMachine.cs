using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void Enter();
    public void Exit();
    public void Update();
    public void PhysicsUpdate();
}
public abstract class StateMachine
{
    public IState currentState;
    // Start is called before the first frame update
    
}
