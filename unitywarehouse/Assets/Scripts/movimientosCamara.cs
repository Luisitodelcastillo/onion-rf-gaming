using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientosCamara : MonoBehaviour
{
    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position;
    }
}
