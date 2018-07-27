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
            Everything everything = new Everything();
            Repl repl = new Repl();
            
        }
    }

    /// <summary>
    /// Read–eval–print loop
    /// </summary>
    class Repl
    {
        static Repl()
        {
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("enter command");
                var command = Parser.Parse(Console.ReadLine());

                //lame logic for exiting, it's a temporary placeholder example anyways. anything but "exit" crashes because can't do null.Execute();
                exit = command.Execute();

                
            }
        }

        public interface ICommand
        {
            bool Execute();
        }

        public class ExitCommand : ICommand
        {
            public bool Execute()
            {
                // exit = true... ugh.
                Console.WriteLine("Exiting!");
                return true;
            }
        }

        public class BorkedCommand : ICommand
        {
            public bool Execute()
            {
                // exit = false ... uuuugghghh.
                Console.WriteLine("Borked.");
                return false;
            }
        }

        //public class StartWorkoutCommand : ICommand
        //{
        //    
        //}

        public static class Parser
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
                   // case "start":
                   //     return new StartWorkoutCommand();
                   // case "stop":
                   //     return new StopWorkoutCommand();
                    //case ""
                    default:
                        return new BorkedCommand();
                }

                return default(ICommand);
            }
        }
    }

    class Everything
    {
        public Everything()
        {
            var client = new Wobu.Everything.Everything.EverythingClient(new Channel("localhost", 3000, ChannelCredentials.Insecure));
            //client.StartWorkout()
        }
    }
}
