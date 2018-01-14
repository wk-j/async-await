using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Await {

    static class Extensions {
        public static TaskAwaiter<(T1, T2)> GetAwaiter<T1, T2>(this (Task<T1>, Task<T2>) tasks)
                => tasks.Transpose().GetAwaiter();

        public static async Task<(T1, T2)> Transpose<T1, T2>(this (Task<T1>, Task<T2>) tasks) {
            var (task1, task2) = tasks;
            return (await task1, await task2);
        }
    }

    class Program {
        static async Task<string> Ps(int i) {
            await Task.Delay(i);
            return i.ToString();
        }
        static async Task Main(string[] args) {
            var (v1, v2) = await (Ps(1), Ps(2));
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }

}