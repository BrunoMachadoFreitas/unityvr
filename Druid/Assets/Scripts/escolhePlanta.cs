using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escolhePlanta : MonoBehaviour
{
   
    public GameObject primeiroAguentador;
    public GameObject placa;
    public GameObject vasos;
    public PlantsName plantaEscolhida;
    private BoxCollider boxPlaca;
    public Canvas canvasPrimeiro;
    public GameObject mostraVasos;
    // Start is called before the first frame update
    void Start()
    {
        boxPlaca = placa.GetComponent<BoxCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void metePlanta()
    {
        boxPlaca.enabled = false;
        canvasPrimeiro.enabled = false;
        placa.GetComponent<cod_plant_contoler>().plantName = plantaEscolhida;
        Instantiate(placa, primeiroAguentador.transform.position, Quaternion.identity);
        placa.gameObject.SetActive(true);
        mostraVasos.gameObject.SetActive(false);
       // primeiroAguentador.gameObject.SetActive(false);


        vasos.gameObject.SetActive(false);
    }
}
