namespace Arrays.Models  {
    using System;

    public class Aluno {
        private string[] nome = new string[5];

        public Aluno(string[] nome, double nota) {
            this.nome = nome;
            this.n1 = nota1;
            this.n2 = nota2;
        }
        public string[] nomes {
            get { return nome; }
            set { nome = value; }
        }
        public double nota1 {
            get { return n1; }
            set { n1 = value; }
        }
        public double nota2 {
            get { return n2; }
            set { n2 = value; }
        }

        public void calcularMedia(){
            double media = (n1 + n2) / 2;
            Console.WriteLine($"Média: {media}");
        }

    }
}