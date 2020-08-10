using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour 
{
    public void OnPointerDown(BaseEventData eventData)
    {
        Debug.Log("오브젝트 클릭");
        //throw new System.NotImplementedException();
    }
}
