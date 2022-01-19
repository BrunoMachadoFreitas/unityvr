using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigo_troca_de_scene : MonoBehaviour
{
    public GameObject player;
    public string scene;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void movimentaTeleport_e_Scene()
    {

        LeanTween.move(player, new Vector3(transform.position.x, transform.position.y + 3.5f, transform.position.z), 3).setEase(LeanTweenType.easeInOutSine).setOnComplete(()=>Application.LoadLevel(scene));
        

    }
}
