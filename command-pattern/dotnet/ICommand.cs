using System.Dynamic;

public interface ICommand {   
    dynamic Execute(dynamic parameters);
}