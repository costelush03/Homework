using hw_21.Services;

var intOps = new MathOperations<int>();
Console.WriteLine(intOps.Add(5, 7));        // 12

var dblOps = new MathOperations<double>();
Console.WriteLine(dblOps.Divide(20, 4));    // 5