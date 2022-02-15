using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_duplicate : MonoBehaviour
{
    // Start is called before the first frame update
   List<GameObject> tables;
  
    private int min = 1;
    public int max = 6;
    public int chosen = 3 ;
    void Start()
    {
        tables = new List<GameObject>();
        //print(this.gameObject.transform.childCount);

        foreach (Transform item in this.gameObject.transform)
        {
            tables.Add(item.gameObject);
        }
        //print(tables.Count);
        

        InvokeRepeating("duplicate", 5,10); //primeiro parametro quantos segundos até primeira vez, de quanto em quanto tempo
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void duplicate()
    {

        int saiu = Random.Range(min, max);
       

        if ( saiu == chosen)
            {
        
      
            int chosen = Random.Range(0, tables.Count - 1);
            tables[chosen].GetComponentInChildren<cod_plant_contoler>().GetComponent<Renderer>().material.shader = Shader.Find("Holistic/Waves");
    
            // print(chosen);
            if (tables[chosen].GetComponentInChildren<cod_plant_contoler>().plantType == PlantType.bad)
                {
                StartCoroutine(ChnageAgain(tables[chosen]));

         
                }
            }


        
    }


    IEnumerator ChnageAgain(GameObject chosenTree)
    {
        GameObject go = GameObject.Instantiate(chosenTree);

        go.transform.SetParent(this.gameObject.transform);
        go.transform.position = chosenTree.transform.position + (new Vector3(2,0,0));

        
        yield return new WaitForSeconds(10);

        chosenTree.GetComponentInChildren<cod_plant_contoler>().GetComponent<Renderer>().material.shader = Shader.Find("Custom/cut-Out");
        go.GetComponentInChildren<cod_plant_contoler>().GetComponent<Renderer>().material.shader = Shader.Find("Custom/cut-Out");

        //After we have waited 5 seconds print the time again.
        yield break;
    }
}
