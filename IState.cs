using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IState<T> where T:MonoBehaviour
{
    protected T _stateContext;

    public void Enter()
    {
        OnEnter(_stateContext);
    }

    public void Step()
    {
        OnStep(_stateContext);
    }

    public void FixedStep()
    {
        OnFixedStep(_stateContext);
    }

    public void Exit()
    {
        OnExit(_stateContext);
    }

    
    protected abstract void OnEnter(T context);
    protected abstract void OnExit(T context);
    protected abstract void OnStep(T context);
    protected abstract void OnFixedStep(T context);
}
