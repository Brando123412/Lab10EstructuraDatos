using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 vectorToMove;
    [SerializeField] float speed;
    public float energy;
    public float currentEnergy=100;
    bool conditionEnergy = true;
    public float saveEnergy;
    void Start(){
        saveEnergy=energy;
    }

    void Update(){
        /*if(conditionEnergy ==  true){
            energy= Mathf.Clamp(energy-Time.deltaTime,0,saveEnergy);
            currentEnergy = (speed*(energy*0.05f))*Time.deltaTime;
            if(energy==0){
                conditionEnergy=false;
            }
        }else{
            energy= Mathf.Clamp(energy+(Time.deltaTime*2),0,saveEnergy);
            if(energy==saveEnergy){
                conditionEnergy=true;
            }
        }*/
        if(currentEnergy==0){
            conditionEnergy=false;
        }else if(currentEnergy == saveEnergy){
            conditionEnergy=true;
        }
        if(conditionEnergy==false){
            currentEnergy= Mathf.Clamp(currentEnergy+Time.deltaTime*5,0,saveEnergy);
        }else{
            transform.position = Vector3.MoveTowards(transform.position, vectorToMove, currentEnergy*Time.deltaTime);
        }
        //transform.position = Vector3.MoveTowards(transform.position, vectorToMove, speed*Time.deltaTime);
    }

    public void ChangeMovePosition(Vector3 destiny, int factorPeso){
        //print("Factor de peso"+ factorPeso);
        currentEnergy= Mathf.Clamp(currentEnergy-factorPeso,0,100);
        vectorToMove= destiny;
        //print(currentEnergy+"gaaaa");
    }
    
}
