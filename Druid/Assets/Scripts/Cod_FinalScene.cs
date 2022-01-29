using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cod_FinalScene : MonoBehaviour
{
    // Start is called before the first frame update
    List<GameObject> teleports;
    void Start()
    {
        teleports = new List<GameObject>();

        CapsuleCollider[] ctemp = GetComponentsInChildren<CapsuleCollider>();

        foreach (CapsuleCollider item in ctemp)
        {
            teleports.Add(item.gameObject);
        }

 
    }

    
    public void AppearOneByOne()
    {
        foreach (GameObject item in teleports)
        {
            LeanTween.moveLocalY(item, -2.57f, 1).setDelay(teleports.IndexOf(item));
        }
    }
 
}
