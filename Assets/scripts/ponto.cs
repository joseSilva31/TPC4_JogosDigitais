using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ponto : MonoBehaviour
{

    public int pontos;
    public int vidas;
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        vidas = 3;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "moeda")
        {
            pontos = pontos + 1;
            Debug.Log("Pontos: " + pontos);
            Destroy(coll.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "inimigo")
        {
            vidas = vidas - 1;
            Debug.Log("Vidas: " + vidas);
            if (vidas == 0)
            {
                Debug.Log("Game Over");
                Destroy(gameObject);
            }
            
        }
    }
    
}
