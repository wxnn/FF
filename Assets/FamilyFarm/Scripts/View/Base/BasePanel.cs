using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class BasePanel:View
{
   public static T Create<T>(string name) where T: BasePanel
    {
        GameObject model = (GameObject) Resources.Load(name);
        GameObject ui = (GameObject)Instantiate(model);
        ui.name = name;
        T panel = ui.AddComponent<T>();
        panel.init();
        return panel;
    }

    public virtual void init()
    {

    }

    public virtual void hide()
    {
        DestroyImmediate(this.gameObject);
        facade.SendMessageCommand(NotiConst.HIDE_PANEL);
    }
}

