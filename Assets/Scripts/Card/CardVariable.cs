using UnityEngine;
using System.Collections;

public class CardVariable
{
    public Card card;
    public CardObject cardObject;

    public CardVariable()
    {
        SetCard(null);
    }

    public CardVariable(Card card)
    {
        SetCard(card);
    }

    // Use this for initialization
    public void SetCard(Card c)
    {
        Debug.Log("Setting cardvar to " + c.name);
        card = c;
    }

    public void CreateObject()
    {
        GameManager.Instance.CreateCardObject(this);
    }
}
