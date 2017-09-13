using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using FluorineFx;

public class DataManager:Manager<DataManager>
{
    public bool inited = false;
   // public ASObject _app_data;

    //public void init(ASObject obj)
    //{
    //    _app_data = obj;
    //}

    //public ASObject app_data
    //{
    //    get
    //    {
    //        return _app_data;
    //    }
    //}

    public Hashtable[] getMapObjectsData()
    {
        //object[] objs = (object[])app_data["map"];
        List<Hashtable> list= new List<Hashtable>();
        Hashtable obj1 = new Hashtable();
        obj1.Add("x", 5);
        obj1.Add("y", 6);
        obj1.Add("itemid", "5");
        list.Add(obj1);

        Hashtable obj2 = new Hashtable();
        obj2.Add("x", 30);
        obj2.Add("y", 66);
        obj2.Add("itemid", "1");
        list.Add(obj2);

        Hashtable obj3 = new Hashtable();
        obj3.Add("x", 100);
        obj3.Add("y", 66);
        obj3.Add("itemid", "1");
        list.Add(obj3);
        return list.ToArray();
        //for (int i = 0; i < objs.Length; i++)
        //{
        //    ASObject map = (ASObject)objs[i];
        //    Debug.Log(map["x"] + "---" + map["y"]);
        //}
    }
}

