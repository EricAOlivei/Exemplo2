using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    internal class Produto
    {
        private string _nome; // <--- Atributo da classe com Properties //Valores alfabéticos por padrão é = null
        public double Preco { get; private set; } // <--- Atributo da classe com Properties
        public int Quantidade { get; private set; } // <--- Atributo da classe com Properties  
                                                    //Valores numéricos por padrão é = 0
        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade) : this() // <--- Construtor (Obriga o usuário a inserta dados)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome // <--- Properties, é a junção da praticidade do atributo
        {                  // com a segurança do método Get& Set
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /*
        public string GetNome() // <--- Get serve para coletar valor para o atributo, 
        {                       // enquanto o atributo for private
            return _nome;
        }

        public void SetNome(string nome)// <--- Set serve para alterar valor para o atributo, 
        {                               // enquanto o atributo for private

            if (_nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }
        */

        public double ValorTotalEmEstoque() // <--- Metodo
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) // <--- Metodo
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade) // <--- Metodo
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() // <--- Padronizar a aparencia da classe quando chamada
        {                                 // apanas pelo estanciamto ( p )
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}