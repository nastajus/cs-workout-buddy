using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Wobu.Everything;

namespace WobuRepl
{
    /// <summary>
    /// in this namespace's / project's entirety, this is only meant as a short-term testing ground, not for long-term final deployment. maximum MVP here.
    /// todo: later replace with appropriate or easy mobile project with larger learning curve, e.g. Xamarin or Android or Unity or something.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            EverythingClient everythingClient = new EverythingClient();
            Repl repl = new Repl();
            
        }
    }

    /// <summary>
    /// Read–eval–print loop
    /// </summary>
    class Repl
    {
        //it just occured to using a static constructor like this is a bad idea, the constructor never finishes.. oi.
        static Repl()
        {
            Console.WriteLine("enter command");

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

        public interface ICommand
        {

            void Execute();
        }

        public class ExitCommand : ICommand
        {
            public void Execute()
            {
                Console.WriteLine("Exiting!");
            }
        }

        public class BorkedCommand : ICommand
        {
            public void Execute()
            {
                // exit = false ... uuuugghghh.
                Console.WriteLine("Borked.");
            }
        }

        //public class StartWorkoutCommand : ICommand
        //{
        //    
        //}

        public static class CommandParser
        {
            public static ICommand Parse(string commandString)
            {
                //parse your string and create Command object
                var commandParts = commandString.Split(' ').ToList();
                var commandName = commandParts[0];
                var args = commandParts.Skip(1).ToList(); //the arguments is after the command

                switch (commandName)
                {
                    //Create command based on CommandName (and maybe arguments)
                    case "exit":
                        return new ExitCommand();
                    //case "start":
                    //    return new StartWorkoutCommand();
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
        public EverythingClient()
        {
            var client = new Wobu.Everything.Everything.EverythingClient(new Channel("localhost", 3000, ChannelCredentials.Insecure));
            //client.StartWorkout()
        }
    }
}
