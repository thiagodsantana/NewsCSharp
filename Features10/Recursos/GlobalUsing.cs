
// Arquivo GlobalUsings.cs
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using FeaturesCSharp.Versao10;

public class GlobalUsings
{
    /*
     * Resumo:  Centraliza essas declarações e elas se aplicam a todos os arquivos de código do projeto. 
            Isso facilita a manutenção e reduz a redundância, especialmente em projetos grandes.
            * Benefícios:
                *   Redução de código redundante: Evita que você precise adicionar os mesmos using em cada arquivo de código.
                *   Facilidade de manutenção: Se você precisar adicionar ou remover um using, pode fazer isso de forma centralizada.
                *   Melhor organização: Mantém os arquivos de código mais limpos e com menos declarações repetidas.


    Como o compilador interpreta
        - Pré-processamento: O compilador coleta todos os global using definidos em arquivos do projeto.
        -  Inserção Automática: Usings são considerados em todos os arquivos do projeto, como se estivessem declarados no início de cada arquivo.
        -  Código IL Gerado: Não possui diferenças com relação ao uso explícito de using. 
            Os global using são apenas uma abstração para simplificar o código-fonte.     
     */

    public void Validar()
    {
        var lista = new List<int> { 1, 2, 3, 4 };
        var soma = lista.Sum();
        Console.WriteLine(soma);
    }
}

