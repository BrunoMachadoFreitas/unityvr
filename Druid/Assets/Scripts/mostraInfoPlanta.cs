using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mostraInfoPlanta : MonoBehaviour
{
    public GameObject progressBar;
    public Outline thisOutline;
    public float timeLeft;
    public float tempoInicio = 0;
    public bool podeContar = false;
    public Image imageProgressBar;
    // Start is called before the first frame update
    void Start()
    {
        tempoInicio = timeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (podeContar && timeLeft > 0)
        {
            timeLeft -= Time.deltaTime * 3 ;
            imageProgressBar.fillAmount = timeLeft / tempoInicio;
        }
    }

    public void mostraProgressBar()
    {
        thisOutline.enabled = true;
        progressBar.gameObject.SetActive(true);
        podeContar = true;
       
    }
   
    public void exitPlanta()
    {
        progressBar.gameObject.SetActive(false);
        podeContar = false;
        thisOutline.enabled = false;
    }

    IEnumerator contaProgress()
    {
        //wait 5 seconds
        yield return new WaitForSeconds(100);

        //destroy this gameobject
        Destroy(this.gameObject);
    }
}
