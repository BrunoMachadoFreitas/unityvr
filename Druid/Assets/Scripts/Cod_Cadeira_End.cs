using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cod_Cadeira_End : MonoBehaviour
{
   public void CadeiraSurge()
    {
        //A cadeira surge, pode ser fixe por uma particulas de po a sair
        LeanTween.moveLocalY(this.gameObject, -0.50f, 10);
    }

    public void PlayerSenta()
    {

    }
}
