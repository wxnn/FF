﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ApplicationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Application");
		L.RegFunction("Quit", Quit);
		L.RegFunction("CancelQuit", CancelQuit);
		L.RegFunction("GetStreamProgressForLevel", GetStreamProgressForLevel);
		L.RegFunction("CanStreamedLevelBeLoaded", CanStreamedLevelBeLoaded);
		L.RegFunction("CaptureScreenshot", CaptureScreenshot);
		L.RegFunction("HasProLicense", HasProLicense);
		L.RegFunction("ExternalCall", ExternalCall);
		L.RegFunction("RequestAdvertisingIdentifierAsync", RequestAdvertisingIdentifierAsync);
		L.RegFunction("OpenURL", OpenURL);
		L.RegFunction("GetStackTraceLogType", GetStackTraceLogType);
		L.RegFunction("SetStackTraceLogType", SetStackTraceLogType);
		L.RegFunction("RequestUserAuthorization", RequestUserAuthorization);
		L.RegFunction("HasUserAuthorization", HasUserAuthorization);
		L.RegVar("streamedBytes", get_streamedBytes, null);
		L.RegVar("isPlaying", get_isPlaying, null);
		L.RegVar("isEditor", get_isEditor, null);
		L.RegVar("isWebPlayer", get_isWebPlayer, null);
		L.RegVar("platform", get_platform, null);
		L.RegVar("isMobilePlatform", get_isMobilePlatform, null);
		L.RegVar("isConsolePlatform", get_isConsolePlatform, null);
		L.RegVar("runInBackground", get_runInBackground, set_runInBackground);
		L.RegVar("dataPath", get_dataPath, null);
		L.RegVar("streamingAssetsPath", get_streamingAssetsPath, null);
		L.RegVar("persistentDataPath", get_persistentDataPath, null);
		L.RegVar("temporaryCachePath", get_temporaryCachePath, null);
		L.RegVar("srcValue", get_srcValue, null);
		L.RegVar("absoluteURL", get_absoluteURL, null);
		L.RegVar("unityVersion", get_unityVersion, null);
		L.RegVar("version", get_version, null);
		L.RegVar("bundleIdentifier", get_bundleIdentifier, null);
		L.RegVar("installMode", get_installMode, null);
		L.RegVar("sandboxType", get_sandboxType, null);
		L.RegVar("productName", get_productName, null);
		L.RegVar("companyName", get_companyName, null);
		L.RegVar("cloudProjectId", get_cloudProjectId, null);
		L.RegVar("webSecurityEnabled", get_webSecurityEnabled, null);
		L.RegVar("webSecurityHostUrl", get_webSecurityHostUrl, null);
		L.RegVar("targetFrameRate", get_targetFrameRate, set_targetFrameRate);
		L.RegVar("systemLanguage", get_systemLanguage, null);
		L.RegVar("backgroundLoadingPriority", get_backgroundLoadingPriority, set_backgroundLoadingPriority);
		L.RegVar("internetReachability", get_internetReachability, null);
		L.RegVar("genuine", get_genuine, null);
		L.RegVar("genuineCheckAvailable", get_genuineCheckAvailable, null);
		L.RegVar("isShowingSplashScreen", get_isShowingSplashScreen, null);
		L.RegVar("logMessageReceived", get_logMessageReceived, set_logMessageReceived);
		L.RegVar("logMessageReceivedThreaded", get_logMessageReceivedThreaded, set_logMessageReceivedThreaded);
		L.RegFunction("AdvertisingIdentifierCallback", UnityEngine_Application_AdvertisingIdentifierCallback);
		L.RegFunction("LogCallback", UnityEngine_Application_LogCallback);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Quit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Application.Quit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CancelQuit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Application.CancelQuit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStreamProgressForLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				float o = UnityEngine.Application.GetStreamProgressForLevel(arg0);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<int>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				float o = UnityEngine.Application.GetStreamProgressForLevel(arg0);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Application.GetStreamProgressForLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanStreamedLevelBeLoaded(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				bool o = UnityEngine.Application.CanStreamedLevelBeLoaded(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<int>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				bool o = UnityEngine.Application.CanStreamedLevelBeLoaded(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Application.CanStreamedLevelBeLoaded");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CaptureScreenshot(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.Application.CaptureScreenshot(arg0);
				return 0;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.Application.CaptureScreenshot(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Application.CaptureScreenshot");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasProLicense(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			bool o = UnityEngine.Application.HasProLicense();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExternalCall(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			string arg0 = ToLua.CheckString(L, 1);
			object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
			UnityEngine.Application.ExternalCall(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RequestAdvertisingIdentifierAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Application.AdvertisingIdentifierCallback arg0 = (UnityEngine.Application.AdvertisingIdentifierCallback)ToLua.CheckDelegate<UnityEngine.Application.AdvertisingIdentifierCallback>(L, 1);
			bool o = UnityEngine.Application.RequestAdvertisingIdentifierAsync(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenURL(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.Application.OpenURL(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStackTraceLogType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.LogType arg0 = (UnityEngine.LogType)ToLua.CheckObject(L, 1, typeof(UnityEngine.LogType));
			UnityEngine.StackTraceLogType o = UnityEngine.Application.GetStackTraceLogType(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetStackTraceLogType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.LogType arg0 = (UnityEngine.LogType)ToLua.CheckObject(L, 1, typeof(UnityEngine.LogType));
			UnityEngine.StackTraceLogType arg1 = (UnityEngine.StackTraceLogType)ToLua.CheckObject(L, 2, typeof(UnityEngine.StackTraceLogType));
			UnityEngine.Application.SetStackTraceLogType(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RequestUserAuthorization(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)ToLua.CheckObject(L, 1, typeof(UnityEngine.UserAuthorization));
			UnityEngine.AsyncOperation o = UnityEngine.Application.RequestUserAuthorization(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasUserAuthorization(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)ToLua.CheckObject(L, 1, typeof(UnityEngine.UserAuthorization));
			bool o = UnityEngine.Application.HasUserAuthorization(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamedBytes(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Application.streamedBytes);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPlaying(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isPlaying);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isEditor(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isEditor);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isWebPlayer(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isWebPlayer);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_platform(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.platform);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMobilePlatform(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isMobilePlatform);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isConsolePlatform(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isConsolePlatform);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_runInBackground(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.runInBackground);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.dataPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingAssetsPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.streamingAssetsPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_persistentDataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.persistentDataPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_temporaryCachePath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.temporaryCachePath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_srcValue(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.srcValue);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_absoluteURL(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.absoluteURL);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unityVersion(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.unityVersion);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_version(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.version);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bundleIdentifier(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.bundleIdentifier);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_installMode(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.installMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sandboxType(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.sandboxType);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_productName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.productName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_companyName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.companyName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cloudProjectId(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.cloudProjectId);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_webSecurityEnabled(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.webSecurityEnabled);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_webSecurityHostUrl(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.webSecurityHostUrl);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetFrameRate(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Application.targetFrameRate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_systemLanguage(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.systemLanguage);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_backgroundLoadingPriority(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.backgroundLoadingPriority);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_internetReachability(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.internetReachability);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_genuine(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.genuine);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_genuineCheckAvailable(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.genuineCheckAvailable);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isShowingSplashScreen(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isShowingSplashScreen);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logMessageReceived(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(UnityEngine.Application.LogCallback)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logMessageReceivedThreaded(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(UnityEngine.Application.LogCallback)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_runInBackground(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Application.runInBackground = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_targetFrameRate(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Application.targetFrameRate = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_backgroundLoadingPriority(IntPtr L)
	{
		try
		{
			UnityEngine.ThreadPriority arg0 = (UnityEngine.ThreadPriority)ToLua.CheckObject(L, 2, typeof(UnityEngine.ThreadPriority));
			UnityEngine.Application.backgroundLoadingPriority = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logMessageReceived(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.logMessageReceived' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)arg0.func;
				UnityEngine.Application.logMessageReceived += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)arg0.func;
				UnityEngine.Application.logMessageReceived -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logMessageReceivedThreaded(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.logMessageReceivedThreaded' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)arg0.func;
				UnityEngine.Application.logMessageReceivedThreaded += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)arg0.func;
				UnityEngine.Application.logMessageReceivedThreaded -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_AdvertisingIdentifierCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Application.AdvertisingIdentifierCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Application.AdvertisingIdentifierCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_LogCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LogCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LogCallback>.Create(func, self);
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

