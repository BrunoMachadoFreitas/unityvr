using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlaVasos : MonoBehaviour
{
    public GameObject vasos;
    public GameObject placa;
    public GameObject aguentador;
    public GameObject japlantouaplanta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void mostraVasos()
    {
        if (japlantouaplanta.GetComponent<escolhePlanta>().japlantou == false)
        {
            if (placa.gameObject.GetComponent<cod_plant_contoler>().tirouPlanta)
            {
                vasos.gameObject.SetActive(true);
                aguentador.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
    public void escondeVasos()
    {
        if (placa.gameObject.GetComponent<cod_plant_contoler>().tirouPlanta)
            vasos.gameObject.SetActive(false);
    }
}
