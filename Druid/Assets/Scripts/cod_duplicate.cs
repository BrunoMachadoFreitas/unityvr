using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_duplicate : MonoBehaviour
{
    // Start is called before the first frame update
   List<GameObject> tables;
    int min = 1;
    int max = 6;
    int chosen = 2;
    void Start()
    {
        tables = new List<GameObject>();
        //print(this.gameObject.transform.childCount);

        foreach (Transform item in this.gameObject.transform)
        {
            tables.Add(item.gameObject);
        }
        print(tables.Count);

        InvokeRepeating("duplicate", 5,10); //primeiro parametro quantos segundos até primeira vez, de quanto em quanto tempo
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void duplicate()
    {

        int saiu = Random.Range(min, max);
        print(saiu);
        if ( saiu == chosen)
            {
        
            int chosen = Random.Range(0, tables.Count - 1);
            print(chosen);
            if (tables[chosen].GetComponentInChildren<cod_plant_contoler>().plantType == PlantType.bad)
                {
                    GameObject go = GameObject.Instantiate(tables[chosen]);
                    go.transform.position = transform.position + transform.right * 3;
                go.transform.SetParent(this.gameObject.transform);
                }
            }


        
    }
}
