using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_move_around_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject growPart;
    public gameProgressControl gameProgess;
    public AudioSource audioSources;
    public AudioClip[] audioClips;
    public AudioClip[] audioClips1;
    public AudioClip[] audioClips2;
    public AudioClip[] audioClipsEnd;
    public float space_around = 1.5f;

    public GameObject targetPrimeiraArvore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void movePrimeiraArvore()
    {
        LeanTween.move(this.gameObject, targetPrimeiraArvore.transform, 10f).setEase(LeanTweenType.easeInOutQuad);
        LeanTween.rotateY(this.gameObject, 300 * 5, 20);
      //  this.gameObject.transform.RotateAround(targetPrimeiraArvore.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
    public void spinAround()
    {
        
    LTSpline ltSpline = new LTSpline(
            new Vector3[] {
                new Vector3(player.transform.position.x, 4, player.transform.position.z) + player.transform.up * space_around,
                new Vector3(player.transform.position.x, 4, player.transform.position.z) - player.transform.forward * space_around,
                new Vector3(player.transform.position.x, 4, player.transform.position.z) + player.transform.up,
                new Vector3(player.transform.position.x, 4, player.transform.position.z) + player.transform.right * space_around,
                new Vector3(player.transform.position.x, 4, player.transform.position.z) - player.transform.forward * space_around,
                new Vector3(player.transform.position.x, 4, player.transform.position.z) + (-player.transform.right) * space_around,
                new Vector3(player.transform.position.x, 4, player.transform.position.z) + player.transform.forward * space_around,
                new Vector3(player.transform.position.x, 7f, player.transform.position.z) + player.transform.forward * space_around,
    }); ;

        LeanTween.moveSpline(this.gameObject, ltSpline, 5f).setOrientToPath(true).setEase(LeanTweenType.easeInOutQuad).setOnComplete(()=> { spinAround(); }); ;
    }

    public void Piscar()
    {
        LeanTween.scale(growPart, Vector3.one * 100, 5f);

      
    }

    public void Regressar()
    {
        LeanTween.scale(growPart,Vector3.one , 1f);

    }

}
