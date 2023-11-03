namespace FazendoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar objeto da classe Aluno
            Aluno a = new()
            {   
                nome = "Vilberto",
                nota1 = 5,
                nota2 = 7
            };
            a.mensagem();
        }
    }
}