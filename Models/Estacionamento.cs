using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

*/
namespace Projeto.Models.Estacionamento
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoHora = 0;
        private List<string> veiculosEstacionados = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {

            _precoInicial = precoInicial;
            _precoHora = precoHora;
        }

        public List<string> GetLista()
        {
            return veiculosEstacionados;
        }

        public void AddVeiculo()
        {
            string placa = Console.ReadLine();
            List<string> lista = GetLista();
            lista.Add(placa);

        }

        public void RemoverVeiculo(decimal precoInicial, decimal precoHora)
        {
            Console.WriteLine("Digite a placa para remover:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            string horas = Console.ReadLine();
            int numero_horas = Convert.ToInt32(horas);
            decimal valorTotal = precoInicial + (precoHora * numero_horas);
            List<string> lista = GetLista();
            lista.Remove(placa);
            Console.WriteLine($"O valor total do estacionamento foi R$ {valorTotal}");

        }
        public void ListarVeiculos()
        {
            List<string> lista = GetLista();
            foreach (var veiculo in lista)
            {
                Console.WriteLine(veiculo);
            }

        }

    }
}