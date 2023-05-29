using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobleLinkList<T>{
    class Node{
        public T Value{get;set;}
        public Node Next {get;set;}
        public Node Previous {get;set;}
        public Node(T value){
            Value =value;
            Next = null;
            Previous = null;
        }
    }
    Node Head{get;set;}
    public int Count =0;
    public void AddNodeAtStart(T value)
    {
        if (Head == null)
        {
            Node newNode = new Node(value);
            Head = newNode;
            Count = Count + 1;
        }
        else
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
            Count = Count + 1;
        }
    }
    public T GetValueStart(){
        return Head.Value;
    }
    public T GetValueEnd(){
        Node lastNode =GetLastNode();
        return lastNode.Value;
    }
    public T GetValueInPosition(int position){
        if(position==0){
            return GetValueStart();
        }else if(position == Count-1){
            return GetValueEnd();
        }else if(position >=Count){
            throw new ExitGUIException();
        }else{
            int iterator =0;
            Node tmpNode=Head;
            while(iterator < position)
            {
                iterator++;
                tmpNode = tmpNode.Next;
            }
            return tmpNode.Value;
        }
    }
    private Node GetLastNode()
    {
        Node LastNode = Head;
        while (LastNode.Next != null)
        {
            LastNode = LastNode.Next;
        }
        return LastNode;
    }
}
