using UnityEngine;
using System.Collections;
using System.Linq;

[CreateAssetMenu(menuName = "CardCache")]
public class CardCache : ScriptableObject
{
    static CardCache _instance = null;
    public Card[] cache;
    
    public static CardCache Instance { get
        {
            if (!_instance)
                _instance = Resources.FindObjectsOfTypeAll<CardCache>().FirstOrDefault();
            return _instance;
        }
    }

    //return card with given name
    public Card GetCard(string name)
    {
        foreach(Card c in cache)
        {
            if (c.name == name)
                return c;
        }
        Debug.Log("Couldn't find card " + name);
        return null;
    }
}
