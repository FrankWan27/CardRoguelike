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
            return null;

        CardVariable c = deck[index - 1];
        deck.RemoveAt(index - 1);
        index--;

        UpdateText();

        return c;
    }

    //hm
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

    public bool isEmpty()
    {
        if (index <= 0)
            return true;
        return false;
    }

    //Updates Remaining Card Count to GUI
    void UpdateText()
    {
        remainingText.text = index.ToString();
    }
}
