using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cod_Cadeira_End : MonoBehaviour
{
    public GameObject poeira;
    public GameObject cameraShake;
   public void CadeiraSurge()
    {
        Vibration.Vibrate();
        poeira.gameObject.SetActive(true);
        cameraShake.SetActive(true);
        //A cadeira surge, pode ser fixe por uma particulas de po a sair
        LeanTween.moveLocalY(this.gameObject, -3f, 10).setOnComplete(()=> LeanTween.moveLocalY(poeira, -0.50f, 2).setOnComplete(()=>poeira.gameObject.SetActive(false) ));
    }

    public void PlayerSenta()
    {

    }
}
