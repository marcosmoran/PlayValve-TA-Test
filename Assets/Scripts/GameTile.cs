using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTile : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] Image _tileImage;
    [SerializeField] Image _tileBG;
    
    // add tile states, spawned, clicked
    void Start()
    {
        OnSpawn();
    }

    void Update()
    {
        
    }

    void OnSpawn()
    {
        _tileBG.raycastTarget = true;
        PlaySpawnAnim();
    }
    public void OnTileClick()
    {
        TileManager.Instance.OnTileClicked(this);
        Debug.Log("Tile Clicked" + this.name);
    }
    public void SetImage(Sprite img)
    {
        _tileImage.sprite = img;
    }

    public void PlaySpawnAnim()
    {
        _animator.SetTrigger("OnSpawn");
    }
    public void PlayMatchAnim() 
    {
        _animator.SetTrigger("OnMatch");
    }
}
