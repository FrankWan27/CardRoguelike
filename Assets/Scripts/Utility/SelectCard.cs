using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard : MonoBehaviour
{
    public CardVariable currentCard;
    public CardDisplay cardDisp;

    public Transform mTransform;


    public void loadCard()
    {
        if (currentCard == null)
            return;

        cardDisp.gameObject.SetActive(true);
    }

    private void Start()
    {
        mTransform = this.transform;
        cardDisp.gameObject.SetActive(false);
    }

    private void Update()
    {
        mTransform.position = Input.mousePosition;
    }
}
