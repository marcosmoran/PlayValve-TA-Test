using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] HomescreenController _homescreen;
    [SerializeField] TransitionController _transition;
    [SerializeField] GamescreenController _gamescreen;
    void Start()
    {
        _homescreen.OnHomescreenEnter();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TransitionScreens();
        }
    }

    void TransitionScreens()
    {
        _homescreen.OnHomescreenExit();
        _gamescreen.OnGamescreenEnter();
    }
}
