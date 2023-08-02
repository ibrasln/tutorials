using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer
{
    public class DelegatesExample : MonoBehaviour
    {
        public ExampleDelegate exampleDelegate;

        private void OnEnable()
        {
            exampleDelegate += MyName;
            exampleDelegate += MySurname;
        }

        private void OnDisable()
        {
            exampleDelegate -= MyName;
            exampleDelegate -= MySurname;
        }

        private void Update()
        {
            exampleDelegate?.Invoke("Ibrahim");
        }

        private void MyName(string name)
        {
            Debug.Log(name);
        }

        private void MySurname(string surname)
        {
            Debug.Log(surname);
        }
    }
    public delegate void ExampleDelegate(string text);
}
