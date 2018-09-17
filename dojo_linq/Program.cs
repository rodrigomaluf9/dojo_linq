using System;
using System.Collections.Generic;
using System.Linq;

namespace dojo_linq
{
    public class Produto {
        public string nome { get; set; }
        public string categoria { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de produtos!");
            List<Produto> produtos = new List<Produto>();
            produtos.AddRange(criarBebidas());
            produtos.AddRange(criarHortifruti());
            produtos.AddRange(criarLaticinios());
            //escreverListaOrdenada(produtos);
            //List<Produto> listaOrdenada = escreverListaOrdenada(produtos);
            //BuscarParteNome(produtos);
            //QuantidadeItensPorCategoria(produtos);
            //BuscarNomeComecamCom(produtos);
            ImprimirListaPaginada(produtos);
            Console.ReadLine();
        }

        private static void QuantidadeItensPorCategoria(List<Produto> produtos)
        {
            Console.WriteLine("Quantidade de itens por categoria!");
            List<Produto> listaFiltradaBebidas = produtos.Where(produto => produto.categoria.Contains("Bebidas Alcoolicas")).ToList<Produto>();
            Console.WriteLine("Quantidade de itens da categoria Bebidas Alcoolicas " + listaFiltradaBebidas.Count());
            List<Produto> listaFiltradaHortifruti = produtos.Where(produto => produto.categoria.Contains("Hortifruti")).ToList<Produto>();
            Console.WriteLine("Quantidade de itens da categoria Hortifruti " + listaFiltradaHortifruti.Count());
            List<Produto> listaFiltradaLaticinios = produtos.Where(produto => produto.categoria.Contains("Laticinios")).ToList<Produto>();
            Console.WriteLine("Quantidade de itens da categoria Laticinios " + listaFiltradaLaticinios.Count());
        }

        private static List<Produto> escreverListaOrdenada(List<Produto> produtos)
        {
            List<Produto> listaOrdenada = produtos.OrderBy(produto => produto.nome).ToList<Produto>();
            Console.WriteLine("Lista Ordenada");
            foreach (Produto produto in listaOrdenada)
            {
                Console.WriteLine(produto.nome);
            }
            return listaOrdenada;
        }

        private static void BuscarParteNome(List<Produto> produtos)
        {
            string trecho = Console.ReadLine();
            List<Produto> listaFiltrada = produtos.Where(produto => produto.nome.ToUpper().Contains(trecho.ToUpper())).ToList<Produto>();

            foreach (Produto produto in listaFiltrada)
            {
                Console.WriteLine(produto.nome.ToString());
            }
        }

        private static void BuscarNomeComecamCom(List<Produto> produtos)
        {
            string trecho = Console.ReadLine();
            List<Produto> listaFiltrada = produtos.Where(produto => produto.nome.ToUpper().StartsWith(trecho.ToUpper())).ToList<Produto>();

            foreach (Produto produto in listaFiltrada)
            {
                Console.WriteLine(produto.nome.ToString());
            }
        }

        private static void ImprimirListaPaginada(List<Produto> produtos)
        {
            List<Produto> lista = produtos.OrderBy(produto => produto.nome).ToList<Produto>();
            foreach (Produto produto in lista)
            {
                Console.WriteLine(produto.nome);
            }
            Console.WriteLine();
            lista = lista.Skip(2).Take(2).ToList();
            foreach (Produto produto in lista)
            {
                Console.WriteLine(produto.nome);
            }
        }

        public IEnumerable<Produto> bebidas = criarBebidas();
        public IEnumerable<Produto> hortifruti = criarHortifruti();
        public IEnumerable<Produto> laticinios = criarLaticinios();


        public static IEnumerable<Produto> criarBebidas()
        {
            List<Produto> retorno = new List<Produto>();
            Produto produto = new Produto();
            produto.categoria = "Bebidas Alcoolicas";
            produto.nome = "Aboslut";
            retorno.Add(produto);
            Produto produto2 = new Produto();
            produto2.categoria = "Bebidas Alcoolicas";
            produto2.nome = "Kaiser";
            retorno.Add(produto2);
            Produto produto3 = new Produto();
            produto3.categoria = "Bebidas Alcoolicas";
            produto3.nome = "Stella";
            retorno.Add(produto3);
            Produto produto4 = new Produto();
            produto4.categoria = "Bebidas Alcoolicas";
            produto4.nome = "Catuaba";
            retorno.Add(produto4);
            //Produto produto5 = new Produto();
            //produto5.categoria = "Bebidas Alcoolicas";
            //produto5.nome = "Amarula";
            //retorno.Add(produto5);

            return retorno;
        }
       
        public static IEnumerable<Produto> criarHortifruti()
        {
            List<Produto> retorno = new List<Produto>();
            Produto produto = new Produto();
            produto.categoria = "Hortifruti";
            produto.nome = "Alfacde";
            retorno.Add(produto);
            Produto produto2 = new Produto();
            produto2.categoria = "Hortifruti";
            produto2.nome = "Laranja";
            retorno.Add(produto2);
            Produto produto3 = new Produto();
            produto3.categoria = "Hortifruti";
            produto3.nome = "Tomate";
            retorno.Add(produto3);
            //Produto produto4 = new Produto();
            //produto4.categoria = "Hortifruti";
            //produto4.nome = "couve";
            //retorno.Add(produto4);
            //Produto produto5 = new Produto();
            //produto5.categoria = "Hortifruti";
            //produto5.nome = "Azeitona";
            //retorno.Add(produto5);

            return retorno;
        }

        public static IEnumerable<Produto> criarLaticinios()
        {
            List<Produto> retorno = new List<Produto>();
            Produto produto = new Produto();
            produto.categoria = "Laticinios";
            produto.nome = "Queijo Prato";
            retorno.Add(produto);
            Produto produto2 = new Produto();
            produto2.categoria = "Laticinios";
            produto2.nome = "Requeijão";
            retorno.Add(produto2);
            Produto produto3 = new Produto();
            produto3.categoria = "Laticinios";
            produto3.nome = "Iogurte";
            retorno.Add(produto3);
            Produto produto4 = new Produto();
            produto4.categoria = "Laticinios";
            produto4.nome = "Leite";
            retorno.Add(produto4);
            Produto produto5 = new Produto();
            produto5.categoria = "Laticinios";
            produto5.nome = "ParMESÃO";
            retorno.Add(produto5);

            return retorno;
        }
    }
}
