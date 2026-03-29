using Unity.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    static int score = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (gameObject.tag == "banana")
        {
            score++;
            Debug.Log("Puntos: " + score);

            Destroy(gameObject);
        }
        else if (gameObject.tag == ("Enemy")) 
        {
            Debug.Log("Jugador muerto");
            Destroy(other.transform.root.gameObject); // destruye al jugador
            Destroy(gameObject);       // destruye la fruta
        }

    }
}
