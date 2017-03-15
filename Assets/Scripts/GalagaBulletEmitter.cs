//Marìa Mercedes Retolaza Reyna, 16339 
//Plataformas Moviles y Video Juegos 
//Secciòn 10 
using UnityEngine;
using System.Collections;

public class GalagaBulletEmitter : BulletEmitter
{

    public new bool BanderaDeDisparo()
    {
        //Validaciòn de, cuando se tenga la señal del fuego y se emite una colisiòn 
        return Input.GetKeyDown("space") && !cooling;
    }
    //Volver a cargar 
    void Update() {
        if (NeedReload()){
            Reload();}

        if (BanderaDeDisparo())
        {
            StartCoroutine(Fire());
        }
    }
}
