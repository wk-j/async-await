using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Deconstruct {

    static class Extensions {
        public static void Deconstruct<T>(this T[] value, out T first, out Span<T> rest) {
            var span = value.AsSpan();
            first = span[0];
            rest = span.Slice(1);
        }
        public static void Deconstruct<T>(this T[] value, out T first, out T second, out Span<T> rest) {
            var span = value.AsSpan();
            first = span[0];
            second = span[1];
            rest = span.Slice(2);
        }
    }

    [MemoryDiagnoser]
    public class Test {

        private int[] values;

        [Params(10, 100)]
        public int Count { set; get; }

        [GlobalSetup]
        public void Setup() => values = new int[Count];

        [Benchmark]
        public void Span() {
            var (a, r1) = values;
            var (z, y, r2) = values;
        }

        [Benchmark]
        public void ArraySegment() {
            var (a, r1) = (values[0], new ArraySegment<int>(values, 1, values.Length - 1));
            var (z, y, r2) = (values[0], values[1], new ArraySegment<int>(values, 2, values.Length - 2));
        }

        [Benchmark]
        public void Take() {
            var (a, r1) = (values[0], values.Skip(1));
            var (z, y, r2) = (values[0], values[1], values.Skip(2));
        }
    }

    class Program {
        static void Main(string[] args) {
            BenchmarkRunner.Run<Test>();
        }
    }
}
