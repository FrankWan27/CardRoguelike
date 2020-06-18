using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    public Text remainingText;
    public int index;

    //Not using a stack because I want to be able to find or preview cards
    List<CardVariable> deck;

    public static DeckManager Instance { get; private set; }

    // Start is called before the first frame update
    void Awake()
    {
        deck = new List<CardVariable>();
        Populate();

        if (Instance != null)
            return;

        Instance = this;
    }


    public CardVariable Pop()
    {
        if (isEmpty())
            RefillFromDiscard();

        CardVariable c = deck[index - 1];
        deck.RemoveAt(index - 1);
        index--;

        UpdateText();

        return c;
    }

    void RefillFromDiscard()
    {
        //Draw entire discard pile
        while(!DiscardManager.Instance.isEmpty())
        {
            AddCard(DiscardManager.Instance.PopRandom());
        }
    }


    private void Populate()
    {
        for (int i = 0; i < 8; i++)
        {
            CardVariable c = new CardVariable(CardCache.Instance.GetCard("Attack"));
            AddCard(c);
        }

    }

    public void AddCard(CardVariable c)
    {
        deck.Add(c);
        index++;

        UpdateText();
    }

    public bool isEmpty() => index <= 0;

    //Updates Remaining Card Count to GUI
    void UpdateText() => remainingText.text = index.ToString();
}
