using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionController : Screen
{
    [SerializeField] Animator _animator;
    public bool transitionFinished = false;

    public void Start()
    {
        base.Start();
    }
    public void OnTransitionEnter()
    {
        base.OnScreenEnter();
        _animator.SetTrigger("OnTransition");
    }


    public void OnTransitionFinished()
    {
        transitionFinished = true;
        base.OnScreenExit();
    }
}
