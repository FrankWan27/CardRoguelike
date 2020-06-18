using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardManager : MonoBehaviour
{
    //Don't know if i want to have a text
    //public Text remainingText;
    //public int index;

    //Not using a stack because I want to be able to find or preview cards
    List<CardVariable> discard;

    public static DiscardManager Instance { get; private set; }

    // Start is called before the first frame update
    void Awake()
    {
        discard = new List<CardVariable>();

        if (Instance != null)
            return;

        Instance = this;
    }

    public void AddCard(CardVariable c)
    {
        discard.Add(c);

    }

    public CardVariable PopRandom()
    {
        int index = Random.Range(0, discard.Count);

        CardVariable cv = discard[index];

        discard.RemoveAt(index);

        return cv;
    }

    public bool isEmpty() => discard.Count <= 0;
   
}