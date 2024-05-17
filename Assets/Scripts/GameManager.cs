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

    [SerializeField] Animator _progressBarAnimator;
    int _coinAmount = 0;
    int tileMatchCounter = 0;
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
        _transition.OnTransitionEnter();
        StartCoroutine(TransitionCoroutine());
    }
    IEnumerator TransitionCoroutine()
    {
        while(_transition.transitionFinished)
        {
            yield return null;
        }
        _gamescreen.OnGamescreenEnter();
    }

    public void OnTileMatched()
    {
        if (tileMatchCounter > 2) return;
        GainCoins(20);
        _progressBarAnimator.SetTrigger("Progress_" + tileMatchCounter.ToString());
        tileMatchCounter++;
        if (tileMatchCounter >= 2) GameWon(); 
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
    public void GameWon()
    {

    }
}
