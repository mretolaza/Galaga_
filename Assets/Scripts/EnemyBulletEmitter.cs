//María Mercedes Retolaza Reyna, 16339 
//Plataformas Moviles y Video Juegos 
//Sección 10 
using UnityEngine;
using System.Collections;

// En esta clase se cargan las balas de los enemigos 

public class EnemyBulletEmitter : BulletEmitter{

    bool IsBelongsToArmy() {
        return gameObject.transform.parent != null;
    }

    void Update(){
        if (IsBelongsToArmy()){
            return;
        }

        if (CanFire()){
            Reload();
            StartCoroutine(Fire());
        }
    }

}
