﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_NetworkManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.NetworkManager), typeof(Manager<LuaFramework.NetworkManager>));
		L.RegFunction("OnInit", OnInit);
		L.RegFunction("Unload", Unload);
		L.RegFunction("CallMethod", CallMethod);
		L.RegFunction("AddEvent", AddEvent);
		L.RegFunction("SendConnect", SendConnect);
		L.RegFunction("SendMessage", SendMessage);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject<LuaFramework.NetworkManager>(L, 1);
			obj.OnInit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unload(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject<LuaFramework.NetworkManager>(L, 1);
			obj.Unload();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CallMethod(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject<LuaFramework.NetworkManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			object[] arg1 = ToLua.ToParamsObject(L, 3, count - 2);
			object[] o = obj.CallMethod(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			LuaFramework.ByteBuffer arg1 = (LuaFramework.ByteBuffer)ToLua.CheckObject<LuaFramework.ByteBuffer>(L, 2);
			LuaFramework.NetworkManager.AddEvent(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendConnect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject<LuaFramework.NetworkManager>(L, 1);
			obj.SendConnect();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<string>(L, 2))
			{
				LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject<LuaFramework.NetworkManager>(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.SendMessage(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<LuaFramework.ByteBuffer>(L, 2))
			{
				LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject<LuaFramework.NetworkManager>(L, 1);
				LuaFramework.ByteBuffer arg0 = (LuaFramework.ByteBuffer)ToLua.ToObject(L, 2);
				obj.SendMessage(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.SendMessageOptions>(L, 3))
			{
				LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject<LuaFramework.NetworkManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.SendMessage(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<object>(L, 3))
			{
				LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject<LuaFramework.NetworkManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendMessage(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject<LuaFramework.NetworkManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.CheckObject(L, 4, typeof(UnityEngine.SendMessageOptions));
				obj.SendMessage(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaFramework.NetworkManager.SendMessage");
			}
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
}

