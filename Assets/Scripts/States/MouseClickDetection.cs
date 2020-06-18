using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Actions/MouseClickDetection")]
public class MouseClickDetection : Action
{
    public override void Execute(float d)
    {
        if (Input.GetMouseButton(0) && !GameManager.Instance.clicking)
        {
            GameManager.Instance.clicking = true;
            PointerEventData pointerData = new PointerEventData(EventSystem.current);
            pointerData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();

            //get all objects our pointer is overlapping with
            EventSystem.current.RaycastAll(pointerData, results);
        
            foreach (RaycastResult r in results)
            {

                IClickable c = r.gameObject.GetComponentInParent<IClickable>();
                if (c != null)
                {
                    c.OnClick();
                    break;
                }
            }
        }

        //released
        if(!Input.GetMouseButton(0))
        {
            GameManager.Instance.clicking = false;
        }
    }
}
