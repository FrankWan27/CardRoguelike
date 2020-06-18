using UnityEngine;
using System.Collections;



//CardObject manages player interaction (Clicking etc)

public class CardObject : MonoBehaviour, IClickable
{
    public CardDisplay disp;
    public ElementLogic currentLogic;
    public CardVariable cardVar;

    public void SetCardVar(CardVariable cv)
    {
        if (cv == null)
            return;
        cardVar = cv;

        disp.SetCard(cv.card);
    }
    public void OnClick()
    {
        if (currentLogic == null)
            return;

        currentLogic.OnClick(this);
    }

    public void OnHover()
    {
        if (currentLogic == null)
            return;
        
        currentLogic.OnHover(this);
    }

    // Use this for initialization

}
    