using System;
using System.Threading.Tasks;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;
using Wobu.Everything;

namespace WobuSchwarz
{
    /// <summary>
    /// Counterpart in C# that is a placeholder maybe for whatever Arnold is doing ... 
    /// 'tis the server here...
    /// this is a .NET CORE project...
    /// </summary>
    class Schwarz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Server : Everything.EverythingBase
    {
        public Server()
        {
            
        }

        public override Task<Workout> StartWorkout(Empty empty, Grpc.Core.ServerCallContext context)
        {

        }
    }
}
