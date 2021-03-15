using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int[] test = new int[5];
        //test[0] = 1;
        //test[1] = 2;
        //test[2] = 3;
        //test[3] = 4;
        //test[4] = 5;
        //
        //foreach (int i in test)
        //{
        //    Debug.Log(i);
        //}
        
        //List<int> myList = new List<int>();
        //
        //// 3
        //myList.Add(3);
        //Debug.Log(myList[0]);
        //
        //// 3 2
        //myList.Add(2);
        //Debug.Log(myList[1]);
        //
        //// 3 2 4 
        //myList.Add(4);
        //Debug.Log(myList[2]);
        //
        //// 3 4
        //myList.RemoveAt(1);
        //Debug.Log(myList[1]);
        //
        //// 3 4 5 
        //myList.Add(5);
        //Debug.Log(myList[2]);
        //
        //foreach (var i in myList)
        //{
        //    Debug.Log(i);
        //}

        //Stack<int> myStack = new Stack<int>();
        //
        //// 3
        //
        //myStack.Push(3);
        //Debug.Log(myStack.Peek());
        //
        //// 2
        //// 3
        //
        //myStack.Push(2); 
        //Debug.Log(myStack.Peek());
        //
        ////4
        ////2
        ////3
        //
        //myStack.Push(4);
        //Debug.Log(myStack.Peek());
        //
        //
        ////2
        ////3
        //
        //myStack.Pop();
        //Debug.Log(myStack.Peek());
        //
        ////5
        ////2
        ////3
        //
        //myStack.Push(5);
        //Debug.Log(myStack.Peek());
        //
        //while (myStack.Count != 0)
        //{
        //    Debug.Log(myStack.Peek());
        //    myStack.Pop();
        //}


        Dictionary<string, int> myDict = new Dictionary<string, int>()
        {
            { "apple", 1000},                                                                                                                                                                                               
            { "orange", 2000},
            { "grape", 3000},
            { "melon", 4000}
        };
        
        Debug.Log(myDict["apple"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
