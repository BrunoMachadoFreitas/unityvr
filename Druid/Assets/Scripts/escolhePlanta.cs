using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escolhePlanta : MonoBehaviour
{
    public GameObject placaPrefab;
    public Transform placeholder;
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
        Instantiate(placaPrefab, placeholder.position, Quaternion.identity);
        placaPrefab.gameObject.transform.parent = placeholder;
        aguentador.gameObject.GetComponent<BoxCollider>().enabled = true;
        placaPrefab.gameObject.GetComponent<cod_plant_contoler>().plantName = PlantsName.Noveleiro;
        vasos.gameObject.SetActive(false);
    }
}
