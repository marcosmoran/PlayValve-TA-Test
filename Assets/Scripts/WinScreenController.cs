using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreenController : Screen
{
    [SerializeField] Animator _animator;
    void Start()
    {
        base.Start();
    }
    public void OnWinScreenEnter()
    {
        base.OnScreenEnter();
        _animator.SetTrigger("OnGameWon");
    }

  
}
