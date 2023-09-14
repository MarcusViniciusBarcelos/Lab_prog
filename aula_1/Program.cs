using System.Diagnostics;


Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();


Console.WriteLine("\nHello, World!\n");


stopwatch.Stop();
TimeSpan tempoDecorrido = stopwatch.Elapsed;


Console.WriteLine("Tempo de resposta: " + tempoDecorrido.TotalMilliseconds + " ms\n");