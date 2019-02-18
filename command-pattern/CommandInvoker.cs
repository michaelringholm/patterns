using System;
using System.Reflection;

public abstract class CommandInvoker {
    public static dynamic InvokeCommand(string command, dynamic parameters) {
        Assembly assembly = Assembly.GetExecutingAssembly();
        Type commandType = assembly.GetType(command);
        var commandInstance = (ICommand)Activator.CreateInstance(commandType);
        return commandInstance.Execute(parameters);
    }
}