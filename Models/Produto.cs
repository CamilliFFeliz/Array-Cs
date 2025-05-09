namespace Arrays.Models  {
    using System;

    public class Produto {
        private string[] nome =  new string[5];

        public Produto (string[] nome, double preco) {
            this.nome = nome;
            this.preco = preco;
        }

        public string[] nomes {
            get {return nome;}
            set {nome = value;}
        }
        public double preco {
            get;
            set;
        }

        public void exibirProduto(){
            for (int i = 0; i < nome.Length; i++) {
                if (!string.IsNullOrEmpty(nome[i])) {
                    Console.WriteLine($"Produto: {nome[i]} | Preço: {preco:C}");
                }
            }
        }

    }
}

