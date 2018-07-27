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
            Console.WriteLine("starting serverEv...");
            //https://grpc.io/docs/tutorials/basic/csharp.html
            
            //Grpc.Core.Server
            Server server = new Server { Ports = { new ServerPort("localhost", 3000, ServerCredentials.Insecure) }};
            server.Start();
            Console.ReadKey();
            server.ShutdownAsync().Wait();
            Console.WriteLine("did it end?");
        }
    }

    class ServerEv : Everything.EverythingBase
    {
        public ServerEv()
        {
            
        }

        public override Task<Workout> StartWorkout(Empty empty, Grpc.Core.ServerCallContext context)
        {
            return Task.FromResult(new Workout { Who = new User{ Username = "Nastajus" }, State = WorkoutState.Start } );
        }

        //hmm... how to track name... 

        //public override Task<Workout> StopWorkout(Empty empty, Grpc.Core.ServerCallContext context)
        //{
        //    return Task.FromResult(new Workout { Who = new User
        //    {
        //        //Username = "Nastajus"
        //    }, State = WorkoutState.Stop });
        //}

        public override async Task GetExercisesOf_S(Exercise exercise, IServerStreamWriter<Exercise> responseStream, ServerCallContext context)
        {
            var responses = exercise;
            for (int x =0; x <=2; x++)
            {
                await responseStream.WriteAsync(responses);
            }
        }

    }
}
