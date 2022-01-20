using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_move_around_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;


    public int space_around = 5;
    void Start()
    {
        spinAround();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spinAround()
    {
        LTSpline ltSpline = new LTSpline(
            new Vector3[] {
                 player.transform.position-(player.transform.up*-1)  + (Vector3.forward*(Random.Range(-space_around,space_around))),
                 player.transform.position-(player.transform.up*-1) + (Vector3.back*(Random.Range(-space_around,space_around))),
                 player.transform.position-(player.transform.up*-1) + (Vector3.right*(Random.Range(-space_around,space_around))),
                 player.transform.position-(player.transform.up*-1) + (Vector3.left*(Random.Range(-space_around,space_around))),
                 player.transform.position-(player.transform.up*-1) + (Vector3.right*(Random.Range(-space_around,space_around))),
                 player.transform.position-(player.transform.up*-1) + (Vector3.forward*(Random.Range(-space_around,space_around))),
                 }) ;

        LeanTween.moveSpline(this.gameObject, ltSpline, 10.0f).setOrientToPath(true).setEase(LeanTweenType.easeInOutQuad).setOnComplete(()=> { spinAround(); }); ;
    }
}
