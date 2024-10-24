class Progam {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Bem vindo ao sistema, digite a senha: ");
        int senha = int.Parse(Console.ReadLine());
        
        while (senha != 2002)
        {
            if (senha != 2002) {
                System.Console.WriteLine("SENHA INCORRETA!");
            } 
            senha = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("ACESSO PERMITIDO!");
    }
}