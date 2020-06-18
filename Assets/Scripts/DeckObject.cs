using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckObject : MonoBehaviour, IClickable
{
    DeckManager dm;
    public void OnClick()
    {
        //Draw a Card
        HandManager.Instance.Draw();
    }

    public void OnHover()
    {
        //Do Nothing
        return;
    }

    // Start is called before the first frame update
    void Start()
    {
        dm = GetComponent<DeckManager>();
    }
}
