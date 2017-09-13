using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LitJson;
using UnityEngine.Events;
using LuaFramework;

public class ShopItem
{
    private Transform ui;
    private RawImage icon;
    private Text nameTxt;
    private Button buyBtn;
    private JsonData _data;
    private ResourceManager.ImageLoadCallBack imageLoadedCallBack;

    public ShopItem(Transform _ui)
    {
        ui = _ui;
        icon = ui.FindChild("Icon").GetComponent<RawImage>();
        nameTxt = ui.FindChild("Name").GetComponent<Text>();
        buyBtn = ui.FindChild("Buy").GetComponent<Button>();
        imageLoadedCallBack = imageLoaded;
    }

    public JsonData data
    {
        set
        {
            _data = value;
            Init();

        }
        get
        {
            return _data;
        }
    }

    public void Init()
    {
        nameTxt.text = (string)data["name"];
        buyBtn.onClick.AddListener(delegate()
        {
            onButtonClick(buyBtn.transform);
        });
        ResourceManager.Instance.LoadImage((string)data["url"]+".png", imageLoadedCallBack);
    }

    private void imageLoaded(Texture2D texture)
    {
        if (texture != null)
        {
            icon.texture = texture;
        }
    }

    private void onButtonClick(Transform target)
    {
        if (target.name == "Buy")
        {
            Debug.Log("dfdfdf");
        }
    }
}
