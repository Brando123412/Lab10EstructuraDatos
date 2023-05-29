using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphControl : MonoBehaviour
{   
    public List<NodeController> allListaNode;
    public NodeController currentNodeControl; 
    public PlayerController player;
    void Start()
    {
        player.ChangeMovePosition(currentNodeControl.gameObject.transform.position,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
