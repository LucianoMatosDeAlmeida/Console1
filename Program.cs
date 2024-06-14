namespace console1 {
	internal class Program {
		static void Main(string[] args) {
			Usuario usuario = new Usuario();
			usuario.nome = "Almeida";
			usuario.login = "root";
			usuario.senha = "qwe123";

			string login;
			string senha;

			do {
				Console.WriteLine("digite seu login: ");
				login = Console.ReadLine();

				Console.WriteLine("digite sua senha: ");
				senha = Console.ReadLine();

				Console.WriteLine("digite novamente: ");

			} while(usuario.logar(login, senha));
			
		}
	}
}
