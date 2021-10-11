using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{

    public Text puntaje;
    public GameObject enemigo;
    float tiempo = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > tiempo)
        {
            Debug.Log(tiempo);
            tiempo = Time.time + 2;
            Instantiate(enemigo, new Vector3(Random.Range(-7, 7), Random.Range(-1, 4), 0f), transform.rotation);
        }

        puntaje.text = "Puntaje: " + Collisions.puntaje;
    }
}
