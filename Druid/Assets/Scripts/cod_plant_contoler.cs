using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlantType
{
    good,
    bad,
    neutral
}
public class cod_plant_contoler : MonoBehaviour
{
    public PlantType plantType;
    // Start is called before the first frame update
  
    public void RemovePlant()
    {
        if(plantType == PlantType.good)
        {
            GetComponentInChildren<TrailRenderer>().startColor = Color.red;
        }
       

        LeanTween.rotateY(this.gameObject, 300*5, 1).setOnComplete(()=> {
            LeanTween.moveY(this.gameObject, 10, 2).setEaseInBounce().setOnComplete(() =>
            {
                this.gameObject.SetActive(false);
            });
        });
       
    }
}
