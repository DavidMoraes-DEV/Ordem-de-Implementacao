using System.Globalization;
namespace Course
{
    class Produto
    {
        //Ordem Sugerida de Boas Praticas Para implementação de Membros de Classes:
        //1º Atributos Privados
        //2º Propriedades autoimplementadas
        //3º Construtores
        //4º Propriedades Customizadas
        //5º Outros Métodos da Classe


        private string _nome; //Exemplo de Atributos Privados
        public double Preco { get; private set; } // Exemplo de Propriedades AutoImplementadas
        public int Quantidade { get; private set; }

       
        public Produto() //Exemplo de Construtores
        {
        }
        public Produto(string nome, double preco, int quantidade) //Exemplo de Construtores
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome //Exemplo de Propriedades Customizadas
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque //Exemplo do resto abaixo como Outros Métodos da Classe
        {
            get { return Preco * Quantidade; }
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}