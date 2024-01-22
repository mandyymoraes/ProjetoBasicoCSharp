using System.Runtime.InteropServices.Marshalling;
using System;
using Projeto.Models;
using Projeto.Models.Estacionamento;

decimal precoInicial = 0;
decimal precoHora = 0;
Estacionamento veiculosEstacionados = new Estacionamento(precoInicial, precoHora);
Console.WriteLine("Bem vindo a central do Estacionamento!");

void Menu()
{
    Console.WriteLine($"Selecione a opcao desejada\n");
    Console.WriteLine("1. Cadastar novo veiculo\n");
    Console.WriteLine("2. Remover veiculo estacionado\n");
    Console.WriteLine("3. Listar os veiculos estacionados\n");
    Console.WriteLine("4. Encerrar o programa");
    string opc = Console.ReadLine();
    switch (opc)
    {
        case "1":
            veiculosEstacionados.AddVeiculo();
            break;
        case "2":
            veiculosEstacionados.RemoverVeiculo(precoInicial, precoHora);
            break;
        case "3":
            veiculosEstacionados.ListarVeiculos();
            break;
        case "4":
            Console.WriteLine("Saindo do programa");
            System.Environment.Exit(1);
            break;


    }

}


string continuar = "S";
do
{
    Menu();
    Console.WriteLine("Deseja continuar cadastrando? S/N");
    continuar = Console.ReadLine();

}
while (continuar == "S");



