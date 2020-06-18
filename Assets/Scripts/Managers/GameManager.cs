using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Keep track of clicks
    public bool clicking = false;
    public State currentState;

    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != null)
            return;

        Instance = this;
    }
    private void Update()
    {
        currentState.Tick(Time.deltaTime);
    }

    //Used by CardVariable to create CardObj in Game
    public void CreateCardObject(CardVariable cardVar)
    {
        GameObject newCard = GameObject.Instantiate(PrefabCache.Instance.cardPrefab, HandManager.Instance.transform);
        CardObject cardObj = newCard.GetComponent<CardObject>();
        cardObj.SetCardVar(cardVar);
        cardVar.cardObject = cardObj;
    }
}
