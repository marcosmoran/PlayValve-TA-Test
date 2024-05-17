using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Screen : MonoBehaviour
{
    [SerializeField] CanvasGroup _canvasGroup;
    protected bool _currentlyAnimating = false;
    protected void Start()
    {
        _canvasGroup.alpha = 0;
    }
    protected void OnScreenEnter()
    {
        FadeScreen(true);
        _canvasGroup.blocksRaycasts = true;
        _canvasGroup.interactable = true;
    }

    protected void OnScreenExit()
    {
        FadeScreen(false);
        _canvasGroup.blocksRaycasts = false;
        _canvasGroup.interactable = false;
    }
    void FadeScreen(bool _fadeIn)
    {
        var fadeVal = _fadeIn ? 1 : 0;
        var dur = _fadeIn ? .5f : .2f;
        _currentlyAnimating = true;
        _canvasGroup.DOFade(fadeVal, dur).OnComplete(() => 
            _currentlyAnimating = false
            );
    }
}
