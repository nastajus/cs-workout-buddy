using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Wobu.Everything;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace WobuRepl
{
    /// <summary>
    /// in this namespace's / project's entirety, this is only meant as a short-term testing ground, not for long-term final deployment. maximum MVP here.
    /// todo: later replace with appropriate or easy mobile project with larger learning curve, e.g. Xamarin or Android or Unity or something.
    /// </summary>
    class Program
    {
        public static EverythingClient Everything { get; private set; }

        static void Main(string[] args)
        {
            // what kind of coupling between these two would be good? 
            // i imagine some kind of decoupled thing is best.. but how ? 

            Everything = new EverythingClient();
            Repl.Run( new[] {"Workout Buddy READ-EVAL-PRINT loop!", "---", "Enter command:"} );
            
        }
    }

    /// <summary>
    /// Read–eval–print loop
    /// </summary>
    static class Repl
    {
        //it just occured to using a static constructor like this is a bad idea, the constructor never finishes.. oi.
        public static void Run(string[] initLines)
        {
            foreach (var line in initLines)
            {
                Console.WriteLine(line);
            }

            while (true)
            {
                Console.Write(" > ");
                var command = CommandParser.Parse(Console.ReadLine());

                if (command.GetType() == typeof(ExitCommand))
                {
                    return;
                }

                command.Execute();
            }
        }

        interface ICommand
        {
            void Execute();
        }

        class ExitCommand : ICommand
        {
            public void Execute()
            {
                Console.WriteLine("Exiting!");
            }
        }

        class BorkedCommand : ICommand
        {
            public void Execute()
            {
                Console.WriteLine("Borked.");
            }
        }

        abstract class ArgumentativeCommand : ICommand
        {
            public List<string> Args { get; private set; }

            protected ArgumentativeCommand(List<string> args)
            {
                Args = args;
            }

            public abstract void Execute();
        }

        class StartWorkoutCommand : ArgumentativeCommand
        {
            public StartWorkoutCommand(List<string> args) : base(args) { }

            public override void Execute()
            {
                foreach (string arg in Args)
                {
                    //Grpc.Core.RpcException: 'Status(StatusCode=Unavailable, Detail="Connect Failed")'
                    Program.Everything.Client.StartWorkout(new Empty()); 
                    Console.WriteLine(arg);
                }

            }
        }

        static class CommandParser
        {
            public static ICommand Parse(string commandString)
            {
                //parse your string and create Command object
                var commandParts = commandString.Split(' ').ToList();
                var commandName = commandParts[0];
                var args = commandParts.Skip(1).ToList(); //the arguments is after the command

                //todo: improve ... probably a away to do this without explicitly duplicating the string in switch cases...
                switch (commandName)
                {
                    case "exit":
                        return new ExitCommand();
                    case "start":
                        return new StartWorkoutCommand(args);
                    //case "stop":
                    //    return new StopWorkoutCommand();
                    //case ""
                    default:
                        return new BorkedCommand();
                }

                return default(ICommand);
            }
        }
    }

    class EverythingClient
    {
        public Everything.EverythingClient Client { get; private set; }

        public EverythingClient()
        {
            Client = new Wobu.Everything.Everything.EverythingClient(new Channel("localhost", 3000, ChannelCredentials.Insecure));
        }
    }
}
