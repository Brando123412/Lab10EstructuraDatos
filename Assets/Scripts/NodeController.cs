using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour
{
    public List<NodeController> listaAddNodes;
    public List<int> factorPeso;
    public int value;
    public NodeController SelectNextNode(){
        int nodeSelected = Random.Range(0,listaAddNodes.Count);
        value= factorPeso[nodeSelected];
        return listaAddNodes[nodeSelected];
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            other.GetComponent<PlayerController>().ChangeMovePosition(SelectNextNode().gameObject.transform.position,value);
        }
    }
}
