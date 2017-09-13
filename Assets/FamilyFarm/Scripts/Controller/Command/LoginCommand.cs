using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using LuaFramework;

public class LoginCommand: BaseCommand
{
    public override void Execute(IMessage message)
    {
        //base.Execute(message);
        Debug.Log(message.Body);
        PlayerPrefs.SetString("uuid", "123");
        GameManager gameManager = GetManager<GameManager>(ManagerName.Game);
        gameManager.currentState(StateConst.LOADING_STATE);
    }
}

