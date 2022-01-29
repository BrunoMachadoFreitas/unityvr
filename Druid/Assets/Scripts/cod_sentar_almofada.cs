using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_sentar_almofada : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sentar()
    {
        LeanTween.move(player, new Vector3(transform.position.x, transform.position.y + 3.5f, transform.position.z), 3).setEase(LeanTweenType.easeInOutSine).setOnComplete(() => {
            LeanTween.moveLocalY(player, this.gameObject.transform.position.y + 3f, 1).setDelay(1);
        });
    }
}
