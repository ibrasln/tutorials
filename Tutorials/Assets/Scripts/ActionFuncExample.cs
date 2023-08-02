using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer
{
    public class ActionFuncExample : MonoBehaviour
    {
        public static Action myStaticEvent;
        public static Action<int> myStaticEventWithInt;

        public static Func<int> myStaticFunc; //returns an int
        public static Func<int, string> myStaticFuncWithInput; //returns a string

        private void OnEnable()
        {
            myStaticEvent += ActionFunction;
            myStaticEventWithInt += ActionFunctionWithInt;

            myStaticFunc += FuncFunctionWithInt;
            myStaticFuncWithInput -= FuncFunctionWithString;
        }

        private void OnDisable()
        {
            myStaticEvent -= ActionFunction;
            myStaticEventWithInt -= ActionFunctionWithInt;
            
            myStaticFunc -= FuncFunctionWithInt;
            myStaticFuncWithInput -= FuncFunctionWithString;
        }

        private void Update()
        {
            myStaticEvent?.Invoke();

            Debug.Log("MyStaticFunc: " + myStaticFunc);
            Debug.Log("MyStaticFuncWithInput: " + myStaticFuncWithInput);
        }

        private void ActionFunction()
        {
            Debug.Log("ActionFunction");
        }

        private void ActionFunctionWithInt(int i)
        {
            Debug.Log(i);
        }

        private int FuncFunctionWithInt()
        {
            return 5;
        }

        private string FuncFunctionWithString(int num)
        {
            return $"I am {num} years old";
        }
    }
}
