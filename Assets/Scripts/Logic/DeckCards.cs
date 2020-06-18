using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Game Elements/My Deck Cards")]
public class DeckCards : ElementLogic
{

    public CardVariable currentCard;
    public override void OnClick(CardObject card)
    {

        HandManager.Instance.Draw();
        Debug.Log("Drawing Card From Deck");
    }

    public override void OnRelease(CardObject card)
    {

    }

    public override void OnHover(CardObject card)
    {

    }
}
