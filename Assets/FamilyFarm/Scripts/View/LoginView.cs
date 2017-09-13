using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


public class LoginView: IState
{
    private GameObject loginRoot;
    private InputField userName;
    public void OpenState()
    {
        loginRoot = GameObject.Find("UICanvas/LoginRoot");
        GameObject prefab = (GameObject)Resources.Load("LoginUI");
        GameObject loginUI = GameObject.Instantiate<GameObject>(prefab);
        loginUI.transform.SetParent(loginRoot.transform, false);
        Button loginBtn = loginUI.GetComponentInChildren<Button>();
        userName = loginUI.GetComponentInChildren<InputField>();
        if(loginBtn != null)
        {
            loginBtn.onClick.AddListener(delegate()
            {
                OnLoginClick();
            });
        }
        loginRoot.SetActive(true);
        Debug.Log("show login panel");
    }

    private void OnLoginClick()
    {
        AppFacade.Instance.SendMessageCommand(CommandConst.LOGIN_CMD,userName.text);
    }

    public void CloseState()
    {
        loginRoot.SetActive(false);
    }
}

