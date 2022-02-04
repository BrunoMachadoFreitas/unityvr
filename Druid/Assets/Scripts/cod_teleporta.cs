using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_teleporta : MonoBehaviour
{
    public GameObject player;
    public GameObject livro;
    public bool isMoving;
    
    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void movimentaTeleport()
    {
        isMoving = true;
        //livro.gameObject.SetActive(false);
        LeanTween.move(player, new Vector3(transform.position.x, transform.position.y + 3.5f, transform.position.z), 3).setEase(LeanTweenType.easeInOutSine).setOnComplete(() => isMoving = false); ;

    }
}
