using FeaturesCSharp.Versao12;
using FeaturesCSharp.Versao13;
using static FeaturesCSharp.Versao12.InlineArrays;

/*
 * =====  C# 13 =====
 */

/*
* ================= ScopedLock =================== 
 */

//Console.WriteLine("Scoped Lock - C# 13");
//ScopedLock.ValidarLockGenerico();
//ScopedLock.ValidarNewLock();


/*
 * ================== Params Collection ==============
 */
//Console.WriteLine("Params Collection - C# 13");
//ParamsCollections.ContarNumeros(1, 2, 3);

//List<int> lista = [1, 2, 3, 4];
//var enumerable = Enumerable.Range(5, 5);
//var hashSet = (new HashSet<int> { 5, 6, 7, 8, 9, 10 });
//int[] array = [1, 2, 3, 4, 5, 6, 7];


//ParamsCollections.ContadorNumeros(lista);
//ParamsCollections.ContadorNumeros(enumerable);
//ParamsCollections.ContadorNumeros(hashSet);
//ParamsCollections.ContarNumeros(array);


/*
 * ============= InlineArrays ======================
 */

//Console.WriteLine("Inline Arrays - C# 12");
//InlineArrayNumbers numbers = default;

//// Acessando os elementos
//numbers[0] = 10;
//numbers[1] = 20;
//numbers[2] = 30;

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(numbers[i]); // Saída: 10, 20, 30
//}

/*
 * ================ Primary Constructors Non Record Types =============
 */

//Console.WriteLine("Primary Constructors Non Record Types - C# 12");
//PrimaryConstructorsNonRecordTypes.Validar();


/*
 * ================ Collection Expressions =============
 */

//Console.WriteLine("Collection Expressions - C# 12");
//CollectionExpressions.Validar();

Console.ReadLine();