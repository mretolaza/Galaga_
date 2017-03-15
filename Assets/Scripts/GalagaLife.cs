//Marìa Mercede Retolaza Reyna, 16339 
//Plataformas Moviles y video Juegos 
//secciòn 10 
using UnityEngine;
using System.Collections;

public class GalagaLife : MonoBehaviour
{

    public GameObject explosionPref;
    // Validaciòn de destruccion de objeto 
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "EnemyBullet" || collider.tag == "Enemy")
        {
            PlayExplosion();
            Destroy(gameObject);
        }
    }
    //Animacion de la explision 
    //La explosion se encontro en una pagina de google, https://www.softonic.com/windows/animacion 
    void PlayExplosion()
    {
        var explosion = (GameObject)Instantiate(explosionPref);
        explosion.transform.position = gameObject.transform.position;
    }
}
