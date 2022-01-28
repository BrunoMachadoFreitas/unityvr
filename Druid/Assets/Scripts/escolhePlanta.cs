using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escolhePlanta : MonoBehaviour
{
   
    public GameObject primeiroAguentador;
    public GameObject aguentador;
    public GameObject vasos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void metePlanta()
    {
        Instantiate(aguentador, primeiroAguentador.transform.position, Quaternion.identity);
       
        aguentador.GetComponentInChildren<cod_plant_contoler>().plantName = PlantsName.Noveleiro;
       // primeiroAguentador.gameObject.SetActive(false);


        vasos.gameObject.SetActive(false);
    }
}
