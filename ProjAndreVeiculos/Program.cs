// See https://aka.ms/new-console-template for more information

using System;
using static Microsoft.AspNetCore.Mvc.Controller;
using Models;
using System.ComponentModel.DataAnnotations;
using ProjAPICarro.Controllers;

Console.WriteLine("Incio do processamento");

Boleto boleto = new Boleto
{
    Id = 1,
    Numero = 30,
    DataVencimento = DateTime.Now, //preenche c/ data e hora atual
};

Console.WriteLine(boleto.DataVencimento.ToString("dd/MM/yyyy"));


//Console.WriteLine(boleto);
//Console.WriteLine(new BoletoesController().Insert(boleto) ? "Registro Inserido!" : "Erro ao inserir!");
