using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{

    List<CardVariable> hand;
    public int maxHandSize;

    public static HandManager Instance { get; private set; }


    void Awake()
    {
        //Default handsize = 3
        maxHandSize = 3;
        hand = new List<CardVariable>();
        
        if (Instance != null)
            return;

        Instance = this;
    }


    //draws one card
    public void Draw()
    {
        CardVariable cardVar = DeckManager.Instance.Pop();
        
        //Out of cards
        if (cardVar == null)
            return;

        cardVar.CreateObject();

        hand.Add(cardVar);
        UpdateCardLayout();
    }

    public void RemoveCard(CardVariable cardVar)
    {
        hand.Remove(cardVar);
    }

    // Update is called once per frame
    void Update()
    {
        if(hand.Count < maxHandSize)
        {
            Draw();
        }
    }

    public void UpdateCardLayout()
    {
        if (hand.Count <= 0)
            return;

        float spacing = (Defs.HAND_RIGHT - Defs.HAND_LEFT) / (hand.Count + 1);
        for (int i = 0; i < hand.Count; i++)
        {
            hand[i].cardObject.transform.position = new Vector3(Defs.HAND_LEFT + spacing * (i + 1), transform.position.y, transform.position.z);
        }
    }
}
