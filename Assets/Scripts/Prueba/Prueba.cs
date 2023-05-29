using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    [SerializeField] GameObject[] listaPositon;
    public DobleLinkList<GameObject> listaSimple;
    void Awake()
    {
        /*DobleLinkList<GameObject> */listaSimple = new DobleLinkList<GameObject>();
        for (int i = 0; i < listaPositon.Length; i++)
        {
            listaSimple.AddNodeAtStart(listaPositon[i]);
        }
    }
    public GameObject ObjectGame(int position){
        return listaSimple.GetValueInPosition(position);
    }
}
