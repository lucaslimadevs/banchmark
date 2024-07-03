using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    public class BenchmarkApp
    {
        private readonly int[] numbers;
        private readonly ICollection<int> numbersList;
        private readonly ICollection<string> stringList;

        private string str1 = "Hello,";
        

        public BenchmarkApp()
        {
            numbers = Enumerable.Range(0, 1000).ToArray();

            numbersList = Enumerable.Range(0, 1000).ToList();

            stringList = Enumerable.Range(0, 1000).Select(i => $"String {i}").ToArray();
        }

        //teste 5 -----------------------------

        [Benchmark]
        public bool TerminaComString()
        {
            return str1.EndsWith(",");
        }

        [Benchmark]
        public bool TerminaComChar()
        {
            return str1.EndsWith(',');
        }

        //teste 4 -----------------------------

        //[Benchmark]
        //public string FiltrarComIgual() 
        //{ 
        //    return stringList.First(e => e == "String 10");
        //}

        //[Benchmark]
        //public string FiltrarComEquals()
        //{
        //    return stringList.First(e => e.Equals("String 10"));
        //}

        //teste 3 -----------------------------

        //[Benchmark]
        //public int obterContagemTotalMetodo()
        //{
        //    return numbersList.Count();
        //}

        //[Benchmark]
        //public int obterContagemTotalAtributo()
        //{
        //    return numbersList.Count;
        //}

        //teste 2 -----------------------------

        //[Benchmark]
        //public string ObterSexoToString() 
        //{ 
        //    var retorno = EnumSexo.Feminino.ToString();

        //    return retorno;
        //}

        //[Benchmark]
        //public string ObterSexoNameof()
        //{
        //    var retorno = nameof(EnumSexo.Feminino);

        //    return retorno;
        //}

        //teste 1 -----------------------------

        //[Benchmark]
        //public int SomaComForLoop()
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}

        //[Benchmark]
        //public int SumComLinq()
        //{
        //    return numbers.Sum();
        //}
    }
}
