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
