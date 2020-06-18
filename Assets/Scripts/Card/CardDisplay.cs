using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    //stores card data
    public Card card;

    //displays to these GUI elements
    public Text nameText;
    public Text descText;
    public Image artImage;
    public Text costText;
    public State stateHolder;

    public void SetCard(Card c)
    {
        if (c == null)
            return;

        card = c;

        LoadCardData();
    }

    private void LoadCardData()
    {
        nameText.text = card.name;
        descText.text = card.description;
        artImage.sprite = card.artwork;
        costText.text = card.cost.ToString();
    }
}
