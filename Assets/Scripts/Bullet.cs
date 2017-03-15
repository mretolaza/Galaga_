//María Mercedes Retolaza Reyna, 16339 
//Plataformas Móviles y Video Juegos 
//Sección 10 

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    //Procedimiento que encuentra una bala y la destruye. 
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (this.tag == "GalagaBullet" && collider.tag == "Enemy" ||
            this.tag == "EnemyBullet" && collider.tag == "Galaga"
        )
        {
            Destroy(gameObject);
        }
    }
}