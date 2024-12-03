
// Arquivo GlobalUsings.cs
global using System;
global using System.Collections.Generic;
global using System.Linq;

// Qualquer outro arquivo no projeto pode usar os namespaces sem repetir os using
public class GlobalUsings
{
    public void Teste()
    {
        var lista = new List<int> { 1, 2, 3, 4 };
        var soma = lista.Sum();
        Console.WriteLine(soma);
    }
}

