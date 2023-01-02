using System;

namespace atividade
{
    class Program
    {
       static void Main(string[] args) 
     {
      float val_pag;
      Console.WriteLine("informar nome");
      string var_nome= Console.ReadLine();
      Console.WriteLine("informar endereço");
      string var_endereço= Console.ReadLine();
      Console.WriteLine("pessoa fisica(f) ou jurídica (j)?");
      string var_tipo = Console.ReadLine();
      if(var_tipo == "f")
      {
      Pessoa_Fisica pf = new Pessoa_Fisica();
      pf.nome = var_nome;
      pf.endereco= var_endereço;
      Console.WriteLine("informar cpf:");
      pf.cpf = Console.ReadLine();
      Console.WriteLine("informar RG:");
      pf.rg= Console.ReadLine();
      Console.WriteLine("informar valor de compra:");
      val_pag= float.Parse(Console.ReadLine());
      pf.Pagar_imposto(val_pag);
      Console.WriteLine("--------Pessoa Física---------");
      Console.WriteLine("Nome.........:" + pf.nome);
      Console.WriteLine("Endereço......" + pf.endereco);
      Console.WriteLine("CPF.........." + pf.cpf);
      Console.WriteLine("RG............" + pf.rg);
      Console.WriteLine(" Valor de compra:" + pf.valor.ToString("C"));
      Console.WriteLine("Imposto.......:" + pf.valor_imposto.ToString("C"));
      Console.WriteLine("Total a pagar: " + pf.total.ToString("C"));
     }
     if(var_tipo == "j")
     {
     Pessoa_Juridica pj = new Pessoa_Juridica();
     pj.nome = var_nome;
     pj. endereco = var_endereço;
     Console.WriteLine("informar CNPJ:");
     pj.cnpj = Console.ReadLine();
     Console.WriteLine("Informar IE:");
     pj.ie= Console.ReadLine();
     Console.WriteLine("informar Valor de compra:");
     val_pag= float.Parse(Console.ReadLine());
     pj.Pagar_imposto(val_pag);
     Console.WriteLine("--------Pessoa Jurídica---------");
     Console.WriteLine(" Nome..........:" + pj.nome);
     Console.WriteLine("Endereço......:" + pj.endereco);
     Console.WriteLine("CNPJ.........:" + pj.cnpj);
     Console.WriteLine("IE............:" + pj.ie);
     Console.WriteLine("valor de compra:" + pj.valor.ToString("C"));
     Console.WriteLine("Imposto.......:" + pj.valor_imposto.ToString("C"));
     Console.WriteLine("total a pagar: " + pj.total.ToString("C"));

     }
     }
     } 
     }