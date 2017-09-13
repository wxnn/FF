using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class GameUI:View
{
    void Awake()
    {
        Button shopBtn = this.transform.FindChild("ShopBtn").GetComponent<Button>();
        shopBtn.onClick.AddListener(delegate ()
        {
            onBtnClick(shopBtn.gameObject);
        });
    }

    private void onBtnClick(GameObject btn)
    {
        switch (btn.name)
        {
            case "ShopBtn":
                PanelManager.ShowPanel<ShopPanel>(ShopPanel.NAME);         
                break;
        }
    }
}
