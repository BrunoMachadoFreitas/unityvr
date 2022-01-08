using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_teleporta : MonoBehaviour
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

    public void movimentaTeleport()
    {
        
        LeanTween.move(player, new Vector3 (transform.position.x, transform.position.y + 3.5f, transform.position.z) , 3).setEase(LeanTweenType.easeInOutSine);

    }
}
