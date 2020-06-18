using UnityEngine;
using System.Collections;

public abstract class ElementLogic : ScriptableObject
{
    public abstract void OnClick(CardObject card);
    public abstract void OnRelease(CardObject card);
    public abstract void OnHover(CardObject card);
}
