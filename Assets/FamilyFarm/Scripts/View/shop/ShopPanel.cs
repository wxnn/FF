using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
using LuaFramework;

public class ShopPanel:BasePanel
{
    public static string NAME = "ShopPanel";
    private List<ShopItem> itemList;
    private List<JsonData> shopDataList;

    public override void init()
    {
    }

    void Awake()
    {
        Button closeBtn = this.transform.FindChild("CloseBtn").GetComponent<Button>();
        closeBtn.onClick.AddListener(delegate ()
        {
            onClickHandler(closeBtn.gameObject);
        });
        itemList = new List<ShopItem>();
        for (int i = 0; i < 8; i++)
        {
            Transform item = this.transform.FindChild("item" + i);
            ShopItem shopItem = new ShopItem(item);
            itemList.Add(shopItem);
        }

        JsonData shopData = ResourceManager.Instance.GetShopData();
        shopDataList = new List<JsonData>();
        foreach (DictionaryEntry id in shopData)
        {
            try
            {
                shopDataList.Add((JsonData)id.Value);
            }
            catch (KeyNotFoundException e)
            {

            }
        }
        OnPageChange(0);
    }

    private void OnPageChange(int page){
        for (int i = 0; i < itemList.Count; i++)
        {
            itemList[i].data = shopDataList[page * 8 + i];
        }
    }

    private void onClickHandler(GameObject btn)
    {
        switch (btn.name)
        {
            case "CloseBtn":
                this.hide();
                break;
        }
    }
}

