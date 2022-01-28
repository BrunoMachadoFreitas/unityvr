using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_move_around_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject growPart;


    public float space_around = 1.5f;
    void Start()
    {
        spinAround();
        Piscar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spinAround()
    {
        
    LTSpline ltSpline = new LTSpline(
            new Vector3[] {
                new Vector3(player.transform.position.x, 2, player.transform.position.y) + player.transform.up * space_around,
                new Vector3(player.transform.position.x, 2, player.transform.position.y) + player.transform.forward * space_around,
                new Vector3(player.transform.position.x, 2, player.transform.position.y) + player.transform.up,
                new Vector3(player.transform.position.x, 2, player.transform.position.y) + player.transform.right * space_around,
                new Vector3(player.transform.position.x, 2, player.transform.position.y) + player.transform.forward * space_around,
                new Vector3(player.transform.position.x, 2, player.transform.position.y) + (-player.transform.right) * space_around,
                new Vector3(player.transform.position.x, 2, player.transform.position.y) + player.transform.forward * space_around,
                new Vector3(player.transform.position.x, 3.5f, player.transform.position.y) + player.transform.forward * space_around,
    }); ;

        LeanTween.moveSpline(this.gameObject, ltSpline, 10.0f).setOrientToPath(true).setEase(LeanTweenType.easeInOutQuad);//.setOnComplete(()=> { spinAround(); }); ;
    }

    void Piscar()
    {
        LeanTween.scale(growPart, growPart.transform.localScale * 20, 1f).setOnComplete(() => { LeanTween.scale(growPart, growPart.transform.localScale / 20, 1f).setOnComplete(()=>Piscar()); });
    }
   
}
