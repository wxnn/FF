using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using System.Reflection;
using System.IO;


namespace LuaFramework {
    public class GameManager : Manager<GameManager> {
        protected static bool initialize = false;
        

        private Dictionary<string, IState> allState;
        private IState curState;
        void Awake()
        {
            DontDestroyOnLoad(gameObject);  //防止销毁自己
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Application.targetFrameRate = AppConst.GameFrameRate;
            Init();
        }

        private void Init()
        {

            GameView gameView = GameObject.Find("Root").GetComponent<GameView>();
            allState = new Dictionary<string, IState>();
            allState.Add(StateConst.LOGIN_STATE, new LoginView());
            allState.Add(StateConst.LOADING_STATE, new LoadingView());
            allState.Add(StateConst.PLAY_STATE, gameView);
            //PlayerPrefs.DeleteAll();
            if (PlayerPrefs.GetString("uuid").Equals(""))
            {
                currentState(StateConst.LOGIN_STATE);
            }
            else
            {
                currentState(StateConst.LOADING_STATE);
            }

        }

        public void currentState(string stateName)
        {
            if (curState != null)
            {
                curState.CloseState();
            }
            bool result = allState.TryGetValue(stateName, out curState);
            if (result)
            {
                curState.OpenState();
            }
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        void OnDestroy() {
            if (LuaManager != null) {
                LuaManager.Close();
            }
            Debug.Log("~GameManager was destroyed");
        }
    }
}