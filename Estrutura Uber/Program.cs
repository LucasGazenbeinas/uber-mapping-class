using System;

namespace Estrutura_Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Corridas:\n");
            var corrida1 = new Corridas();
            {
                corrida1.ID_Corrida();
                corrida1.Usuario_Corrida();
                corrida1.Horario_Corrida();
                corrida1.Valor_Corrida();
                corrida1.ID_Usuario();
                corrida1.Forma_Pagamento();
                corrida1.ID_Motorista();
            }
            Console.WriteLine("\n\nUsuarios:\n");
            var usuario1 = new Usuario();
            {
                usuario1.ID_Usuario();
                usuario1.Nome_Usuario();
            }
            Console.WriteLine("\n\nMotoristas:\n");
            var motorista1 = new Motorista();
            {
                motorista1.ID_Motorista();
                motorista1.Nome_Motorista();
                motorista1.Preco_KM();
            }
            Console.WriteLine("\n\nFormas de Pagamento:\n");
            var fopagamento = new ForPagamento();
            {
                fopagamento.Forma_Pagamento();
            }
            Console.ReadKey();
        }
    }

    class Corridas:Motorista
    {

        public void ID_Corrida()
        {
            Console.WriteLine("ID da Corrida: 1");
        }

        public void Usuario_Corrida()
        {
            Console.WriteLine("Usuario Corrida: Gabriel");
        }

        public void Horario_Corrida()
        {
            Console.WriteLine("Horário da Corrida: 19:23 - 19:58");
        }

        public void Valor_Corrida()
        {
            Console.WriteLine("Valor da Corrida: "+65.00);
        }

        public void ID_Usuario()
        {
            Console.WriteLine("ID do Usuario: "+9);
        }

        public void Forma_Pagamento()
        {
            Console.WriteLine("Forma de Pagamento: Cartão");
        }
    }

    class Usuario
    {
        public void ID_Usuario()
        {
            Console.WriteLine("ID do Usuario: "+9);
        }

        public void Nome_Usuario()
        {
            Console.WriteLine("Nome do Usuario: Gabriel");
        }
    }

    class Motorista
    {
        public void ID_Motorista()
        {
            Console.WriteLine("ID do motorista: "+10);
        }

        public void Nome_Motorista()
        {
            Console.WriteLine("Nome do motorista: Anderson");
        }

        public void Preco_KM()
        {
            Console.WriteLine("Preço/KM: "+9.00);
        }
    }

    class ForPagamento
    {
        public void Forma_Pagamento()
        {
            Console.WriteLine("Forma de Pagamento: Dinheiro, Cartão");
        }
    }
}
