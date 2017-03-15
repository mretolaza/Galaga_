//María Mercedes Retolaza Reyna, 16339 
//Plataformas Móviles y video Juegos 
//Sección 10 

using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    //Procedimiento que mueve a los enemigos en la pantalla 
    public void Move()
    {
        Vector2 pos = transform.position;

        if (pos.y < -5.5f){
            pos.y = 5.5f;
        }

        var speed = 1.0f;
        pos.y = pos.y - Time.deltaTime * speed;
        pos.x = Mathf.Sin(pos.y) * 3;
        transform.position = pos;
    }

}

