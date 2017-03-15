//Marìa Mercedes Retolaza Reyna, 16339 
//Plataformas Mòviles y Video Juegos 
//Seccion 10 
using UnityEngine;
using System.Collections;
//Procedimiento que evalua el porcentaje entre cada jugador 
public class EnemyHealth : MonoBehaviour
{
    //Declaraciòn de variables 
    public GameObject explosionPref;
    private Vector2 attackPosition;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "GalagaBullet" || collider.tag == "Galaga"){
            PlayExplosion();

            GameObject scoreobj = GameObject.FindGameObjectWithTag("Score");
            Score score = (Score)scoreobj.GetComponent(typeof(Score));
            score.OnHitEnemy();

            Destroy(gameObject);
        }
    }

    void PlayExplosion() {
        var explosion = (GameObject)Instantiate(explosionPref);
        explosion.transform.position = gameObject.transform.position;
    }
}
