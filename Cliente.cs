using System;

class Cliente {
  private string nome;
  private string cpf;
  private double dinheiro;
  
  //ainda não sei o que esta realizando abaixo
  public Cliente(string n, string c, double d){
    nome = n;
    cpf=c;
    dinheiro = d;
  }

  public string getNome(){
    return nome;
  }

  public double getDinheiro(){
    return dinheiro;
  }
}



