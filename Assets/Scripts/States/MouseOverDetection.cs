using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Actions/MouseOverDetection")]
public class MouseOverDetection : Action
{
    public override void Execute(float d)
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current);
        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();

        //get all objects our pointer is overlapping with
        EventSystem.current.RaycastAll(pointerData, results);


        foreach (RaycastResult r in results)
        {
            IClickable c = r.gameObject.GetComponentInParent<IClickable>();
            if(c != null)
            {
                c.OnHover();
                break;
            }
        }
    }
}
