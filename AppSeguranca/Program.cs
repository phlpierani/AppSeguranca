using System;

namespace SecurityApp
{
    // Classe que simula o sistema de segurança
    class SecuritySystem
    {
        private bool alarmActive = false;

        // Método para ativar o alarme
        public void ActivateAlarm()
        {
            alarmActive = true;
            Console.WriteLine("Alarme ativado! Uma possível invasão foi detectada.");
            SendAlert();
        }

        // Método para desativar o alarme
        public void DeactivateAlarm()
        {
            alarmActive = false;
            Console.WriteLine("Alarme desativado. Sistema de segurança normalizado.");
        }

        // Método para simular o envio de um alerta
        private void SendAlert()
        {
            Console.WriteLine("Enviando alerta para o usuário...");
            // Aqui você pode integrar uma API de envio de SMS, notificação por email, etc.
        }

        // Método para simular a detecção de um evento de segurança
        public void DetectEvent()
        {
            Console.WriteLine("Verificando o ambiente...");
            Random rnd = new Random();
            int chance = rnd.Next(0, 10);

            if (chance > 5) // Simula uma chance de 50% de detectar um evento
            {
                ActivateAlarm();
            }
            else
            {
                Console.WriteLine("Nenhum evento suspeito detectado.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // A linha foi movida para cá
            Console.WriteLine("Hello, World!");

            SecuritySystem securitySystem = new SecuritySystem();

            Console.WriteLine("Sistema de segurança iniciado.");

            while (true)
            {
                Console.WriteLine("Pressione 'E' para simular a detecção de um evento, ou 'Q' para sair.");
                char input = Console.ReadKey(true).KeyChar;

                if (input == 'E' || input == 'e')
                {
                    securitySystem.DetectEvent();
                }
                else if (input == 'Q' || input == 'q')
                {
                    Console.WriteLine("Encerrando o sistema...");
                    break;
                }
            }
        }
    }
}
