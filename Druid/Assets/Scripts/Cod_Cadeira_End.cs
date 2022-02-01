using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cod_Cadeira_End : MonoBehaviour
{
    public GameObject poeira;
   public void CadeiraSurge()
    {
        Handheld.Vibrate();
        poeira.gameObject.SetActive(true);
        //A cadeira surge, pode ser fixe por uma particulas de po a sair
        LeanTween.moveLocalY(this.gameObject, -0.50f, 10).setOnComplete(()=>poeira.gameObject.SetActive(false));
    }

    public void PlayerSenta()
    {

    }
}
