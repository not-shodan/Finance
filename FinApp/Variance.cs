Here's a complete example demonstrating covariance, contravariance, and invariance in C#:

using System;
using System.Collections.Generic;

namespace VarianceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Covariance example
            Console.WriteLine("=== Covariance ===");
            IEnumerable<object> objects = new List<string> { "Hello", "World" }; // Covariance works
            foreach (var obj in objects)
            {
                Console.WriteLine(obj); // Outputs: Hello, World
            }

            // Contravariance example
            Console.WriteLine("\n=== Contravariance ===");
            Action<object> printObject = (obj) => Console.WriteLine($"Object: {obj}");
            Action<string> printString = printObject; // Contravariance works
            printString("This is a string."); // Outputs: Object: This is a string.

            // Invariance example
            Console.WriteLine("\n=== Invariance ===");
            List<string> stringList = new List<string> { "A", "B", "C" };
            // List<object> objectList = stringList; // Error: Invariant type List<T>
            ProcessList(stringList); // This works

            // Covariance with delegates
            Console.WriteLine("\n=== Covariance with Delegates ===");
            Func<string> stringProducer = () => "Generated string";
            Func<object> objectProducer = stringProducer; // Covariance works
            Console.WriteLine(objectProducer()); // Outputs: Generated string

            // Contravariance with delegates
            Console.WriteLine("\n=== Contravariance with Delegates ===");
            Action<object> objectConsumer = (obj) => Console.WriteLine($"Consuming object: {obj}");
            Action<string> stringConsumer = objectConsumer; // Contravariance works
            stringConsumer("Delegated string."); // Outputs: Consuming object: Delegated string.
        }

        // A method to process a list (to demonstrate invariance explicitly)
        static void ProcessList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Processing: {item}");
            }
        }
    }
}

Explanation

1. Covariance:

The IEnumerable<object> is assigned a List<string> because IEnumerable<T> is covariant.

This allows us to treat List<string> as IEnumerable<object>.



2. Contravariance:

An Action<object> can accept an Action<string> because Action<T> is contravariant.

This is useful when the method argument types differ.



3. Invariance:

List<string> cannot be assigned to List<object> because List<T> is invariant.

We explicitly demonstrate this using a method.



4. Delegates:

Covariance and contravariance are tested using Func<T> and Action<T>.




Output

=== Covariance ===
Hello
World

=== Contravariance ===
Object: This is a string.

=== Invariance ===
Processing: A
Processing: B
Processing: C

=== Covariance with Delegates ===
Generated string

=== Contravariance with Delegates ===
Consuming object: Delegated string.

This example covers all three aspects of variance, showcasing how they can be applied in real-world scenarios.

