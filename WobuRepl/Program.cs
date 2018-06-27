using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WobuRepl
{
    /// <summary>
    /// in this namespace's / project's entirety, this is only meant as a short-term testing ground, not for long-term final deployment. maximum MVP here.
    /// todo: later replace with appropriate or easy mobile project with larger learning curve, e.g. Xamarin or Android or something.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Repl repl = new Repl();
            
        }
    }

    /// <summary>
    /// Read–eval–print loop
    /// </summary>
    class Repl
    {
        // Static constructor to initialize the static variable.
        // It is invoked before the first instance constructor is run.

        static Repl()
        {
            var exit = false;
            while (exit == false)
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
                return true;
            }
        }

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
                    case "exit": return new ExitCommand();
                    //case default: 
                }

                return default(ICommand);
            }
        }

        //void Init()
        //{

        //}
    }
}
