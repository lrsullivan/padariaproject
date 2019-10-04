using System;

private class Produto{
private string nome;
private double preco;
private int quantidade;

public Produto(string name, double valor, int qnt){
  nome = name;
  preco = valor;
  quantidade = qnt;
}
    public getNome(){
  return = nome;
    }
    public void calcular (double taxa){
    if (taxa > 0)
  preco = taxa*1000;
    } 
      public void troco (double tr){
      if(dinheiro < preco){
    Console.WriteLine("Dinheiro insuficiente");
      }
  tr = dinheiro - preco;
    }
}