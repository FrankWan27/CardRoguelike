using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Game Elements/My Hand Cards")]
public class HandCards : ElementLogic
{
    
    public CardVariable currentCard;
    public override void OnClick(CardObject card)
    {
        //currentCard.Set(card);
        

        Debug.Log("This card is in my hand" + this.name);
    } 

    public override void OnHover(CardObject card)
    {

    }
}
