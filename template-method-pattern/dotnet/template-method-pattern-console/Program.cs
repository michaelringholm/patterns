using System;

namespace com.opusmagus
{
    class Program
    {
        static void Main(string[] args)
        {
            var processOrderCommand = new ProcessOrderCommand(null, null);
            //logger.info( "Template Method Pattern - Started..." );
            processOrderCommand.Execute(new ProcessOrderInputModel());
            //logger.info( "Template Method Pattern - Ended!" );
        }
    }
}
