//Marìa Mercedes Retolaza Reyna, 16339 
//Plataformas Moviles y Video Juegos  
//Secciòn 10 

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Restart : MonoBehaviour {

	void Start () {}
	
	void Update () {
		if (Input.GetKeyDown ("space")) {
			SceneManager.LoadScene (0);
		}
	}
}
