using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    public Action[] actions;
    public void Tick(float d)
    {
        foreach(Action a in actions)
        {
            a.Execute(d);
        }
    }
}
