using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("CLICK");
        this.GetComponent<Image>().color = Color.cyan;
        this.GetComponentInChildren<MeshRenderer>().material.color = Color.yellow;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("CLICK");
        this.GetComponent<Image>().color = Color.cyan;
        this.GetComponentInChildren<MeshRenderer>().material.color = Color.yellow;
    }
}
