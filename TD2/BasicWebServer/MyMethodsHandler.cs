﻿using BasicWebServer;
using System;
using System.Reflection;


public class MyMethodsHandler
{
    private readonly Type type;

    public MyMethodsHandler() { type = typeof(MyMethods); }

    // Reflection
    public string GetMethodResult(string method, string param1, string param2)
    {
        object classInstance = Activator.CreateInstance(type, null);
        MethodInfo methodInfo = type.GetMethod(method);
        if (methodInfo == null) return string.Empty;
        /*if (string.IsNullOrWhiteSpace(param2))
        {
            return (string)methodInfo.Invoke(classInstance, new[] { param1 });
        }
        else
        {*/
        return (string)methodInfo.Invoke(classInstance, new[] { param1, param2 });
        //}
    }
}