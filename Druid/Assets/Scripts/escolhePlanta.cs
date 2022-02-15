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

    public bool japlantou = false;
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
        Vector3 rotationVector = transform.rotation.eulerAngles;
        rotationVector.x = 90;
        placa.GetComponent<cod_plant_contoler>().plantName = plantaEscolhida;
        Instantiate(placa, new Vector3(primeiroAguentador.transform.position.x, primeiroAguentador.transform.position.y + 1f, primeiroAguentador.transform.position.z) , Quaternion.Euler(rotationVector));
       
        placa.gameObject.SetActive(true);
        

        //placa.transform.rotation = Quaternion.Euler(rotationVector);
        // primeiroAguentador.gameObject.SetActive(false);


        vasos.gameObject.SetActive(false);
        japlantou = true;
    }
}
