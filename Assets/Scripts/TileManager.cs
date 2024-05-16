using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
public class TileManager : MonoBehaviour
{
    public int tileCount;
    public List<Transform> tileParent;
    public List<Sprite> tileSpritesList;
    [SerializeField] GameObject _tilePrefab;

    void CreateTile(Transform parent)
    {
        GameObject _tileInstance = Instantiate(_tilePrefab, parent);
        GameTile _gameTileInstance = _tileInstance.GetComponent<GameTile>();
        _gameTileInstance.SetImage(tileSpritesList[UnityEngine.Random.Range(0, tileSpritesList.Count)]);
    }

    private void Start()
    {
        foreach(Transform tileParent in tileParent)
        {
            for(int i = 0; i < tileCount; i++)
            {
                CreateTile(tileParent);
            }
        }
    }
}


  
