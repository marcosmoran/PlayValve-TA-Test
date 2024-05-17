using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEventHandler : MonoBehaviour
{

    [SerializeField] TransitionController _transitionController;

    public void OnAnimationFinished()
    {
        _transitionController.OnTransitionFinished();
    }
}
