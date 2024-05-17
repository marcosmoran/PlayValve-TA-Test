using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] HomescreenController _homescreen;
    [SerializeField] TransitionController _transition;
    [SerializeField] GamescreenController _gamescreen;
    [SerializeField] TextMeshProUGUI _coinAmountText;

    int _coinAmount = 0;
    void Start()
    {
        _coinAmountText.text = "0";
        _homescreen.OnHomescreenEnter();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GainCoins(20);
        }
    }

   public void TransitionScreens()
    {
        _homescreen.OnHomescreenExit();
        _gamescreen.OnGamescreenEnter();
    }
    public void GainCoins(int amountGained)
    {
        var oldCoinAmount = _coinAmount;
        _coinAmount += amountGained;
        _coinAmountText.transform.localScale = new Vector3(1.2f, 1.2f, 0);
        _coinAmountText.color = Color.green;
        StartCoroutine(CoinGainCoroutine(oldCoinAmount, amountGained + 1));
        
    }
    IEnumerator CoinGainCoroutine(int oldCoinAmount, int coinDiff )
    {
        int counter = 0;
        while(counter < coinDiff)
        {
            _coinAmountText.text = (oldCoinAmount + counter).ToString();
            counter++;
            yield return null;
        }
        _coinAmountText.transform.localScale = new Vector3(1, 1, 0);
        _coinAmountText.color = Color.white;
    }
}
