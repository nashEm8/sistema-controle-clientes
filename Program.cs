using System;
using Atividade.Classes;

namespace Atividade
{
  class Program
  {
    static void Main(String[] args)
    {
      float val_pag;
      Console.WriteLine("Informe o nome:");
      string var_nome = Console.ReadLine();

      Console.WriteLine("Informe o endereço:");
      string var_endereco = Console.ReadLine();

      Console.WriteLine(@"
      Selecione:

      (F) - Pessoa Física
      (J) - Pessoa Jurídica"); 
      string var_tipo = Console.ReadLine();

     switch(var_tipo){
      case "f":
        PessoaFisica cliente_pf = new PessoaFisica();
        cliente_pf.nome = var_nome;
        cliente_pf.endereco = var_endereco;

        Console.WriteLine("Informe o CPF:");
        cliente_pf.cpf = Console.ReadLine();

        Console.WriteLine("Informe o RG:");
        cliente_pf.rg = Console.ReadLine();

        Console.WriteLine("Informe o valor de compra:");
        val_pag = float.Parse(Console.ReadLine());

        cliente_pf.Pagar_Imposto(val_pag);
        Console.WriteLine("---------- Pessoa Física ----------");
        Console.WriteLine("Nome: " + cliente_pf.nome);
        Console.WriteLine("Endereço: " + cliente_pf.endereco);
        Console.WriteLine("CPF: " + cliente_pf.cpf);
        Console.WriteLine("RG: " + cliente_pf.rg);
        Console.WriteLine("Valor de compra: " + cliente_pf.valor);
        Console.WriteLine("Imposto: " + cliente_pf.valor_imposto);
        Console.WriteLine("Total a pagar: " + cliente_pf.total);
      break;

      case "j":
        PessoaJuridica cliente_pj = new PessoaJuridica();
        cliente_pj.nome = var_nome;
        cliente_pj.endereco = var_endereco;

        Console.WriteLine("Informe o CNPJ:");
        cliente_pj.cnpj = Console.ReadLine();

        Console.WriteLine("Informe a IE:");
        cliente_pj.ie = Console.ReadLine();

        Console.WriteLine("Informe o valor de compra:");
        val_pag = float.Parse(Console.ReadLine());

        cliente_pj.Pagar_Imposto(val_pag);

        Console.WriteLine("---------- Pessoa Jurídica ----------");
        Console.WriteLine("Nome: " + cliente_pj.nome);
        Console.WriteLine("Endereço: " + cliente_pj.endereco);
        Console.WriteLine("CNPJ: " + cliente_pj.cnpj);
        Console.WriteLine("IE: " + cliente_pj.ie);
        Console.WriteLine("Valor de compra: " + cliente_pj.valor);
        Console.WriteLine("Imposto: " + cliente_pj.valor_imposto);
        Console.WriteLine("Total a pagar: " + cliente_pj.total);
      break;
     }

    }
  }
}