using BasicWebServer;
using System;
using System.Reflection;


public class MyMethodsHandlerQ3
{
    private readonly Type type;

    public MyMethodsHandlerQ3() { type = typeof(MyMethodsQ3); }

    // Reflection
    public string GetMethodResult(string method, string param1)
    {
        object classInstance = Activator.CreateInstance(type, null);
        MethodInfo methodInfo = type.GetMethod(method);
        if (methodInfo == null) return string.Empty;
        return (string)methodInfo.Invoke(classInstance, new[] { param1 });
    }
}