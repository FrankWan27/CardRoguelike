using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Game Elements/My Hand Cards")]
public class HandCards : ElementLogic
{
    
    public CardVariable currentCard;

    public override void OnClick(CardObject card)
    {
        //Don't let user make multiple components by dragging out of the screen
        if (card.GetComponent<SelectCard>())
            return;

        SelectCard select = card.gameObject.AddComponent<SelectCard>();
        select.SetObject(card);
    } 

    public override void OnRelease(CardObject card)
    {
        Destroy(card.gameObject.GetComponent<SelectCard>());
        
        //Released in playing field
        if (card.transform.position.y > Defs.HAND_TOP)
        {
            //play CARD


            DiscardManager.Instance.AddCard(card.cardVar);
            HandManager.Instance.RemoveCard(card.cardVar);

            Destroy(card.gameObject);
        }
        else
        {
            //Return to hand
        }
        HandManager.Instance.UpdateCardLayout();
    }

    public override void OnHover(CardObject card)
    {
    }
}
