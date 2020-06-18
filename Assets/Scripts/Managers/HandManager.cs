using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{

    public DeckManager dm;

    List<CardVariable> hand;
    public int maxHandSize;

    public static HandManager Instance { get; private set; }


    //1920x1080
    private const int LEFTBOUND = 200;
    private const int RIGHTBOUND = 1920 - 200;


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
        CardVariable cardVar = dm.Pop();
        
        //Out of cards
        if (cardVar == null)
            return;

        cardVar.CreateObject();

        hand.Add(cardVar);
    }

    // Update is called once per frame
    void Update()
    {
        if(hand.Count < maxHandSize)
        {
            Draw();
        }
        if(hand.Count > 0)
            UpdateCardLayout();
    }

    void UpdateCardLayout()
    {
        float spacing = (RIGHTBOUND - LEFTBOUND) / (hand.Count + 1);
        for (int i = 0; i < hand.Count; i++)
        {
            Vector3 cardPos = hand[i].cardObject.transform.position;
            hand[i].cardObject.transform.position = new Vector3(LEFTBOUND + spacing * (i + 1), cardPos.y, cardPos.z);
        }
    }
}
