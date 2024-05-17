using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HomescreenController : Screen
{
    [SerializeField] GameObject _VFX;
    public bool currentlyAnimating => base._currentlyAnimating;
    void Start()
    {
        base.Start();
    }
    
   public void OnHomescreenEnter()
    {
        base.OnScreenEnter();
    }
   public void OnHomescreenExit()
    {
        base.OnScreenExit();
        _VFX.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
