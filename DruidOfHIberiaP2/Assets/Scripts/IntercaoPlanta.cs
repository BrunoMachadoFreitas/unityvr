using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntercaoPlanta : MonoBehaviour { 

    public Button btnSelecao;
    public Text txtm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            btnSelecao.gameObject.SetActive(true);
            txtm.gameObject.SetActive(true);
        }
       
    }

    public void onClick()
    {
        Debug.Log("clicou");
    }
}
