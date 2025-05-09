using System;
using Arrays.Models;

class Program {
    static void Main(){
        Console.WriteLine("Arrays em C#");

        // Criação de Produtos 
        Produto p1 = new Produto(new string[] {"Alana"}, 10.0);
        Produto p2 = new Produto(new string[] {"Camilli"}, 10.0);
        Produto p3 = new Produto(new string[] {"Mariele"}, 10.0);
        Produto p4 = new Produto(new string[] {"Samantha"}, 10.0);
        Produto p5 = new Produto(new string[] {"Laísa"}, 10.0);

        Console.WriteLine("Exibindo produtos:");
        p1.exibirProduto();
        p2.exibirProduto();
        p3.exibirProduto();
        p4.exibirProduto();
        p5.exibirProduto();

        // Criação de Alunos
        Aluno a1 = new Aluno(new string[] {"Alana"}, 10.0, 9.0);
        Aluno a2 = new Aluno(new string[] {"Camilli"}, 9.0, 3.0);
        Aluno a3 = new Aluno(new string[] {"Mariele"}, 8.0, 5.0);
        Aluno a4 = new Aluno(new string[] {"Samantha"}, 7.0, 9.0);
        Aluno a5 = new Aluno(new string[] {"Laísa"}, 9.0, 8.0);

        Console.WriteLine("Exibindo alunos:");
        a1.calcularMedia();
        a2.calcularMedia();
        a3.calcularMedia();
        a4.calcularMedia();
        a5.calcularMedia();

    }
}


