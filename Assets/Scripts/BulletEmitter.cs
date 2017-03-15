//María Mercedes Retolaza Reyna, 16339 
//Plataformas Móviles y Videjo Juegos 
// Sección 10 

using UnityEngine;
using System.Collections;

// En esta clase se declaran los game objets que se van a utilizar 
// al igual que inicializar procesos 
//Tambien se tienen los metodos de lo que tienen que realizar las balas 
public class BulletEmitter : MonoBehaviour
{

    // Saca una bala desde el objeto 
    public GameObject bulletEmitter;

    // bullet prefab referencia del prefab 
    public GameObject bulletPref;

    // bandera que evita que el jugador vuelva a crear una bala 
    public bool cooling = false;

    // velocidad de la bala 
    public float bulletSpeedScale;

    // Vector2.up or Vector.down
    public Vector2 bulletDirection;

    // Una vez se carga la bala se puede disparar 
    public GameObject loadedBullet;

    // tiempo de choque 
    public float coolingSeconds;

    // bullet tag
    public string bulletTag;

    //----------------------------------------------------------// 
    public IEnumerator Fire()
    {
        cooling = true;

        // fire: add force to bullet
        Rigidbody2D rigidbody = loadedBullet.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(bulletDirection * bulletSpeedScale);
        loadedBullet.tag = bulletTag;

        // destroy loaded bullet after 10s if it's fired.
        Destroy(loadedBullet, 10.0f);

        // set loadedBullet to null to make sure only one loaded bullet will be created.
        loadedBullet.transform.parent = null;
        loadedBullet = null;

        // disable cooling flag after fire
        yield return new WaitForSeconds(coolingSeconds);
        cooling = false;
    }

    public bool NeedReload()
    {
        // Si el emisor se está enfriando, no hay necesidad de volver a cargar
        // Si hay una viñeta cargada, no hay necesidad de volver a cargar
        return !cooling && !loadedBullet;
    }

    public void Reload()
    {
        //Carga de la bala  en la posición del emisor
        loadedBullet = (GameObject)Instantiate(bulletPref, bulletEmitter.transform.position, Quaternion.identity);
        //Seguimiento del objeto 
        loadedBullet.transform.parent = gameObject.transform;
    }

    public bool CanFire()
    {
        return !cooling;
    }


}
