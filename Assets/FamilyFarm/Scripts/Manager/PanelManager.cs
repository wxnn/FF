using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using LuaInterface;

namespace LuaFramework {
    public class PanelManager : Manager<PanelManager> {
        private Transform parent;

        Transform Parent {
            get {
                if (parent == null) {
                    GameObject go = GameObject.FindWithTag("PanelLayer");
                    if (go != null) parent = go.transform;
                }
                return parent;
            }
        }

        public void ShowPanel<T>(string name) where T : BasePanel
        {
            if (Parent.FindChild(name) != null)
            {
                return;
            }
            T panel = BasePanel.Create<T>(name);
            panel.transform.SetParent(Parent, false);
            facade.SendMessageCommand(NotiConst.SHOW_PANEL);
        }

        /// <summary>
        /// lua������壬������Դ������
        /// </summary>
        /// <param name="type"></param>
        public void CreatePanel(string name, LuaFunction func = null) {
            string assetName = name; //+ "Panel";
            string abName = name.ToLower() + AppConst.ExtName;
            if (Parent.FindChild(name) != null) return;

#if ASYNC_MODE
            ResManager.LoadPrefab(abName, assetName, delegate(UnityEngine.Object[] objs) {
                if (objs.Length == 0) return;
                GameObject prefab = objs[0] as GameObject;
                if (prefab == null) return;

                GameObject go = Instantiate(prefab) as GameObject;
                go.name = assetName;
                go.layer = LayerMask.NameToLayer("Default");
                go.transform.SetParent(Parent);
                go.transform.localScale = Vector3.one;
                go.transform.localPosition = Vector3.zero;
                go.AddComponent<LuaBehaviour>();

                if (func != null) func.Call(go);
                Debug.LogWarning("CreatePanel::>> " + name + " " + prefab);
            });
#else
            GameObject prefab = ResManager.LoadAsset<GameObject>(name, assetName);
            if (prefab == null) return;

            GameObject go = Instantiate(prefab) as GameObject;
            go.name = assetName;
            go.layer = LayerMask.NameToLayer("Default");
            go.transform.SetParent(Parent);
            go.transform.localScale = Vector3.one;
            go.transform.localPosition = Vector3.zero;
            go.AddComponent<LuaBehaviour>();

            if (func != null) func.Call(go);
            Debug.LogWarning("CreatePanel::>> " + name + " " + prefab);
#endif
        }

        /// <summary>
        /// �ر����
        /// </summary>
        /// <param name="name"></param>
        public void ClosePanel(string name) {
            var panelName = name;// + "Panel";
            var panelObj = Parent.FindChild(panelName);
            if (panelObj == null) return;
            BasePanel panel = panelObj.GetComponent<BasePanel>();
            if( panel != null)
            {
                panel.hide();
            }else {
                DestroyImmediate(panelObj.gameObject);
            }
            facade.SendMessageCommand(NotiConst.HIDE_PANEL);
        }

        public bool havePanelOpened()
        {
            foreach(Transform child in Parent)
            {
                if (child.gameObject.activeSelf== true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}