using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class INFOSCREEN : MonoBehaviour
{
    public GameObject InfoScreen; //riferimento alla schermata info

    void Start()
    {
        //stringa seguente non funziona se non metto UnityEngineUI
        GetComponent<Button>().onClick.AddListener(OnButtonClick);

    }

    void OnButtonClick()

    {
        gameObject.SetActive(false);
        InfoScreen.SetActive(true);

    }
    
}
