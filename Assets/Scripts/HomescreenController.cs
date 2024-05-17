using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HomescreenController : Screen
{
    [SerializeField] GameObject _VFX;
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
