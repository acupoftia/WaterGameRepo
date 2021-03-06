﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace masterFeature
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                //do not put singletons into game objects, if you must, post in programming discord channel and @calebadb and add line below
                //_instance = (T)FindObjectOfType(typeof(T));
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent<T>();
                    obj.name = typeof(T).ToString();
                }
                return _instance;
            }
        }
    }
}
