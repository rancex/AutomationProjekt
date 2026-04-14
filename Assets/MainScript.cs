using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _stuffText;

    [SerializeField]
    private string _stuffTextContent;

    public void Start()
    {
        _stuffText.text = "";
    }
    
    public void UI_StuffButton()
    {
        _stuffText.text = _stuffTextContent;
    }
}
