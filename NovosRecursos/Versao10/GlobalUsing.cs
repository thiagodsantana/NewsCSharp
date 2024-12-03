
// Arquivo GlobalUsings.cs
global using System;
global using System.Collections.Generic;
global using System.Linq;

public class GlobalUsings
{
    /*
     * Pré-processamento: O compilador coleta todos os global using definidos em arquivos do projeto.
     * Inserção Automática: Usings são considerados em todos os arquivos do projeto, como se estivessem
            *  declarados no início de cada arquivo.
     * Código IL Gerado: O código IL gerado não possui diferenças com relação ao uso explícito de using. 
            * Os global using são apenas uma abstração para simplificar o código-fonte.
     */
    public void Teste()
    {
        var lista = new List<int> { 1, 2, 3, 4 };
        var soma = lista.Sum();
        Console.WriteLine(soma);
    }
}

