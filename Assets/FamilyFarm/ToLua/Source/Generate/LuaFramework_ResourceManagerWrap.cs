﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_ResourceManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.ResourceManager), typeof(Manager<LuaFramework.ResourceManager>));
		L.RegFunction("Initialize", Initialize);
		L.RegFunction("GetItemConf", GetItemConf);
		L.RegFunction("GetShopData", GetShopData);
		L.RegFunction("LoadImage", LoadImage);
		L.RegFunction("LoadPrefab", LoadPrefab);
		L.RegFunction("LoadAssetBundle", LoadAssetBundle);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("inited", get_inited, set_inited);
		L.RegVar("Instance", get_Instance, set_Instance);
		L.RegFunction("ImageLoadCallBack", LuaFramework_ResourceManager_ImageLoadCallBack);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject<LuaFramework.ResourceManager>(L, 1);
			obj.Initialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItemConf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject<LuaFramework.ResourceManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			LitJson.JsonData o = obj.GetItemConf(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetShopData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject<LuaFramework.ResourceManager>(L, 1);
			LitJson.JsonData o = obj.GetShopData();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadImage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject<LuaFramework.ResourceManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.ResourceManager.ImageLoadCallBack arg1 = (LuaFramework.ResourceManager.ImageLoadCallBack)ToLua.CheckDelegate<LuaFramework.ResourceManager.ImageLoadCallBack>(L, 3);
			obj.LoadImage(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadPrefab(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject<LuaFramework.ResourceManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			LuaFunction arg2 = ToLua.CheckLuaFunction(L, 4);
			obj.LoadPrefab(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject<LuaFramework.ResourceManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.AssetBundle o = obj.LoadAssetBundle(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inited(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)o;
			bool ret = obj.inited;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inited on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, LuaFramework.ResourceManager.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_inited(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.inited = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inited on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Instance(IntPtr L)
	{
		try
		{
			LuaFramework.ResourceManager arg0 = (LuaFramework.ResourceManager)ToLua.CheckObject<LuaFramework.ResourceManager>(L, 2);
			LuaFramework.ResourceManager.Instance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaFramework_ResourceManager_ImageLoadCallBack(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<LuaFramework.ResourceManager.ImageLoadCallBack>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<LuaFramework.ResourceManager.ImageLoadCallBack>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

