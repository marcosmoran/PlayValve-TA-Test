using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamescreenController : Screen
{
    [SerializeField] TileManager _tilemanager;
    public bool currentlyAnimating => base._currentlyAnimating;
    void Start()
    {
        base.Start();
    }
    public void OnGamescreenEnter()
    {
        base.OnScreenEnter();
        StartCoroutine(OnScreenEnterCoroutine());
    }
    public void OnGamescreenExit()
    {
        base.OnScreenExit();
    }
    IEnumerator OnScreenEnterCoroutine()
    {
        while (currentlyAnimating)
        {
            yield return null; 
        }
        _tilemanager.SetTiles();
    }
}
