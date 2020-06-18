using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard : MonoBehaviour
{
    public CardObject cardObj;

    public Transform mTransform;

    public void SetObject(CardObject cardObj)
    {
        this.cardObj = cardObj;
        mTransform = cardObj.transform;
    }

    private void Update()
    {
        mTransform.position = Input.mousePosition;
    }
}
