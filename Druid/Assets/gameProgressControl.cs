using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FasesDoJogo
{
    Inicio =0,
    instrucao = 1,
    plantar = 2,
    meio = 3,
    fim = 4

}

public class gameProgressControl : MonoBehaviour
{
    
    
    public FasesDoJogo faseActual = FasesDoJogo.Inicio;
    public cod_move_around_Player druida;
    public somDruidajunior druidaJunior;
    public Cod_FinalScene cod_FinalScene;

    private int vez = 0;
    private int druidaind=0;
    private int juniroindex = 0;
    private bool acabei = false;


    private float myOwnProgress; //same as progess but doesnt go back
    public float MyOwnProgress  // property
    {
        get { return myOwnProgress; }   // get method
        set { 

            if (value  > myOwnProgress) {
                //faseActual = (FasesDoJogo)((int)faseActual + 1);

                if(value > 20 && value < 40 && (int)faseActual < (int)FasesDoJogo.instrucao)
                {
                    faseActual = FasesDoJogo.instrucao;
                    druida.spinAround();
                    druida.audioSources.Stop();
                    druidaJunior.audioSources.Stop();
                    StartCoroutine(parte2());
                }
                else if (value > 40 && value < 60 && (int)faseActual < (int)FasesDoJogo.meio)
                {
                    faseActual = FasesDoJogo.meio;
                    druida.audioSources.Stop();
                    druida.audioSources.clip = druida.audioClips[3];
                    druida.audioSources.Play();
                }
                else if (value > 60 && value < 80 && (int)faseActual < (int)FasesDoJogo.plantar)
                {
                    faseActual = FasesDoJogo.plantar;
                    druida.audioSources.Stop();
                    druidaJunior.audioSources.Stop();
                    StartCoroutine(parte3());
                }
                else if (value > 80 && value < 100 && (int)faseActual < (int)FasesDoJogo.fim)
                {
                    faseActual = FasesDoJogo.fim;
                    acabei = true;
                    druida.audioSources.clip = druida.audioClips[4];
                    druida.audioSources.Play();
                    cod_FinalScene.AppearOneByOne();
                }

                /*switch (faseActual)
                {
                    case FasesDoJogo.Inicio:
                        
                        break;
                    case FasesDoJogo.instrucao:
                        druida.spinAround();
                        druida.audioSources.Stop();
                        druidaJunior.audioSources.Stop();
                        StartCoroutine(parte2());
                        //audioSources.PlayOneShot(audioClips[2]);

                        break;
                    
                    case FasesDoJogo.plantar:
                        druida.audioSources.Stop();
                        druidaJunior.audioSources.Stop();
                        StartCoroutine(parte3());
                       
                        break;
                    case FasesDoJogo.meio:
                        druida.audioSources.Stop();
                        druida.audioSources.clip = druida.audioClips[3];
                        druida.audioSources.Play();
                        break;

                    case FasesDoJogo.fim:
                        druida.audioSources.Stop();
                        if (!acabei) 
                        {
                            acabei = true;
                            druida.audioSources.clip = druida.audioClips[4];
                            druida.audioSources.Play();
                            cod_FinalScene.AppearOneByOne();
                        }

                        break;
                    default:
                        break;
                }*/


                myOwnProgress = value; }; }  // set method
    }

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(parte1());
        
    }

    public void gerirParte1()
    {
        
        if(!druida.audioSources.isPlaying && vez % 2 == 0)
        {
            druida.audioSources.clip = druida.audioClips[druidaind];
            druida.audioSources.Play();
            druidaind++;
            StartCoroutine("tempoEspera");
            vez++;
        }
        if (!druidaJunior.audioSources.isPlaying && vez % 2 != 0)
        {
      
            druidaJunior.audioSources.clip = druidaJunior.audioClips[juniroindex];
            druidaJunior.audioSources.Play();
            juniroindex++;
            StartCoroutine("tempoEspera");
            vez++;
        }


    }

    IEnumerator parte1()
    {
        while (true)
        {
            if (!druida.audioSources.isPlaying && vez % 2 == 0 && druida.audioClips.Length > druidaind)
            {
                druida.audioSources.clip = druida.audioClips[druidaind];
                druida.audioSources.Play();
                druida.Piscar();
                druidaind++;
                yield return new WaitForSeconds(druida.audioSources.clip.length);
                vez++;
            }
            else if (!druidaJunior.audioSources.isPlaying && vez % 2 != 0 && druidaJunior.audioClips.Length > juniroindex)
            {
                druidaJunior.audioSources.clip = druidaJunior.audioClips[juniroindex];
                druidaJunior.audioSources.Play();
                juniroindex++;
                yield return new WaitForSeconds(druidaJunior.audioSources.clip.length);
                vez++;
            }
            else if(!druidaJunior.audioSources.isPlaying && !druida.audioSources.isPlaying)
            {
                druida.movePrimeiraArvore();
                yield return null;
            }
         
            yield return null;
        }

       
    }

    IEnumerator parte2()
    {
        vez = 0;
        while (true)
        {
            if (!druida.audioSources.isPlaying && vez % 2 != 0 && druida.audioClips1.Length > druidaind)
            {
                druida.audioSources.clip = druida.audioClips1[druidaind];
                druida.audioSources.Play();
                druida.Piscar();
                druidaind++;
                yield return new WaitForSeconds(druida.audioSources.clip.length);
                vez++;
            }
            else if (!druidaJunior.audioSources.isPlaying && vez % 2 == 0 && druidaJunior.audioClips1.Length > juniroindex)
            {
                druidaJunior.audioSources.clip = druidaJunior.audioClips1[juniroindex];
                druidaJunior.audioSources.Play();
                juniroindex++;
                yield return new WaitForSeconds(druidaJunior.audioSources.clip.length);
                vez++;
            }
           

            yield return null;
        }


    }

    IEnumerator parte3()
    {
        vez = 0;
        while (true)
        {
            if (!druida.audioSources.isPlaying && vez % 2 != 0 && druida.audioClips2.Length > druidaind)
            {
                druida.audioSources.clip = druida.audioClips2[druidaind];
                druida.audioSources.Play();
                druida.Piscar();
                druidaind++;
                yield return new WaitForSeconds(druida.audioSources.clip.length);
                vez++;
            }
            else if (!druidaJunior.audioSources.isPlaying && vez % 2 == 0 && druidaJunior.audioClips2.Length > juniroindex)
            {
                druidaJunior.audioSources.clip = druidaJunior.audioClips2[juniroindex];
                druidaJunior.audioSources.Play();
                juniroindex++;
                yield return new WaitForSeconds(druidaJunior.audioSources.clip.length);
                vez++;
            }


            yield return null;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
