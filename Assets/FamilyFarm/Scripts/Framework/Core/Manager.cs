using UnityEngine;
using System.Collections;
using LuaFramework;

public class Manager<T> : Base, IManager where T:Base {

    public static T _instance;
    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<T>();
            }
            return _instance;
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
