using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class mostraInfoPlanta : MonoBehaviour
{
    public GameObject progressBar;
  
    public float timeLeft;
    public float tempoInicio = 0;
    public bool podeContar = false;
    public Image imageProgressBar;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Canvas canvas;

    public Text textProgress;
    private int timeToInt = 0;
    private float progress = 0;
    public bool podeTirar = false;
    public Transform player;

    public GameObject jatirouParaPlantar;
    // Start is called before the first frame update
    void Start()
    {
        tempoInicio = timeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.LookAt(player);
        timeToInt = (int)progress;
        if (podeContar && timeLeft > 0)
        {
            timeLeft -= Time.deltaTime * 20 ;
            progress += Time.deltaTime * 20;
            imageProgressBar.fillAmount = timeLeft / tempoInicio;

            textProgress.text = timeToInt.ToString() +  "%";
        }
      
            mostraText();
        
    }

    public void mostraProgressBar()
    {
       
        progressBar.gameObject.SetActive(true);
        podeContar = true;
        if (jatirouParaPlantar.gameObject.GetComponent<cod_plant_contoler>().tirouPlanta == false)
        {
            canvas.gameObject.SetActive(true);
        }
    }
   
    public void exitPlanta()
    {
        progressBar.gameObject.SetActive(false);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        podeContar = false;
       
        canvas.gameObject.SetActive(false);
    }

   public void mostraText()
    {
      
            if (timeLeft <= 75)
            {
                text1.gameObject.SetActive(true);
            }
            if (timeLeft <= 50)
            {
                text2.gameObject.SetActive(true);
            }
            if (timeLeft <= 25)
            {
                text3.gameObject.SetActive(true);
            }
            if (timeLeft <= 5)
            {
                text4.gameObject.SetActive(true);
                podeTirar = true;
            }
       
    }
}
