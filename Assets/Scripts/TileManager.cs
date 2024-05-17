using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using UnityEngine.UI;
public class TileManager : MonoBehaviour
{
    public int tileCount;
    public List<Transform> tileParent;
    public List<Sprite> tileSpritesList;
    [SerializeField] RectTransform _selectedTileArea;
    [SerializeField] GameObject _tilePrefab;
    [SerializeField] Transform _selectedTilesParent;
    List<GameTile> _selectedTiles = new List<GameTile>();
    
    private int totalSpots = 5; 
    private int currentSpotIndex = 0;
    private int matchCount = 0;
    int matchLimit = 3;
    public static TileManager Instance { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SetTiles()
    {
        foreach (Transform tileParent in tileParent)
        {
            for (int i = 0; i < tileCount; i++)
            {
                CreateTile(tileParent);
            }
            
        }
    }
    void CreateTile(Transform parent)
    {
        GameObject _tileInstance = Instantiate(_tilePrefab, parent);
        GameTile _gameTileInstance = _tileInstance.GetComponent<GameTile>();
        _gameTileInstance.SetImage(tileSpritesList[UnityEngine.Random.Range(0, tileSpritesList.Count)]);
    }

    public void OnTileClicked(GameTile tile)
    {
        _selectedTiles.Add(tile);
        RectTransform spriteRect = tile.GetComponent<RectTransform>();
        
        spriteRect.SetParent(_selectedTileArea);
        float widthPerSprite = _selectedTileArea.rect.width / totalSpots;
        spriteRect.anchoredPosition = new Vector2(widthPerSprite * currentSpotIndex + widthPerSprite / 2, 0);
        currentSpotIndex++;
        matchCount++;
        tile.PlaySpawnAnim();
        if (matchCount == matchLimit)
        {
            foreach(GameTile selectedTile in _selectedTiles)
            {
                selectedTile.PlayMatchAnim();
            }
            currentSpotIndex = 0;
            matchCount = 0;
        }
    }

 
}


  
