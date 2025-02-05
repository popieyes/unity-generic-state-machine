using System.Linq;
using System.Collections.Generic;
using UnityEngine;


public class StateMachine<T> where T : MonoBehaviour
{
    protected IState<T> _initialState;
    protected IState<T> _currentState;
    protected List<IState<T>> _states;

    public IState<T> InitialState => _initialState;
    public IState<T> CurrentState => _currentState;


    public void Change<T>()
    {
        _currentState.Exit();

        _states.First((x) => x is T);

        _currentState.Enter();
    }

}
