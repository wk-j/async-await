using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Awaiter {
    static class Extensions {
        public static TaskAwaiter<(T1, T2)> GetAwaiter<T1, T2>(this (Task<T1>, Task<T2>) tasks)
                => tasks.Transpose().GetAwaiter();

        public static async Task<(T1, T2)> Transpose<T1, T2>(this (Task<T1>, Task<T2>) tasks) {
            var (task1, task2) = tasks;
            await Task.WhenAll(task1, task2);
            return (task1.Result, task2.Result);
        }
    }

    class Program {
        static async Task Main(string[] args) {
            async Task<string> f1(int x) => await Task.Factory.StartNew(() => $"Hello {x}");

            var (v1, v2) = await (f1(1), f1(2));

            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }
}
