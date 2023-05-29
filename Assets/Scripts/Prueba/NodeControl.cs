using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeControl : MonoBehaviour
{
    [SerializeField] Prueba prueba;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelecNextNode(){
        int nodeSelected = Random.Range(0,prueba.listaSimple.Count);
    }
}
