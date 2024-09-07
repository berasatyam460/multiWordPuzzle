using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonClick : MonoBehaviour
{
    [SerializeField]GameEvent buttonEvent;
    string text_InChild;
   
    public void onclick()
    {
        text_InChild = this.GetComponentInChildren<TextMeshProUGUI>().text;
        buttonEvent.Raise(this, text_InChild);
    }
}
