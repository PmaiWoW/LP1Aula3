using System;
using System.Text;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializar variáveis
            string pergunta, resposta;
            bool talk = true;

            //fazer pergunta ao utilizador
            Console.WriteLine("What knowledge do you seek, child?");
            pergunta = Console.ReadLine();

            //switch case p/ verificar a pergunta, dando a resposta
            Console.OutputEncoding = Encoding.UTF8;

            //chat loop
            while(talk == true) {

                //switch case c/ várias perguntas e dadas 
                switch (pergunta)
                {
                    case "What's your name?":
                        resposta = "I don't have one";
                        break;
                    case "How are you?":
                        resposta = "I'm ok.";
                        break;
                    case "What are you plans in this class?":
                        resposta = "Pass LP1, hopefully.";
                        break;
                    case "Are you alive?":
                        resposta = "I'm not sure";
                        break;
                    case "What do you like?":
                        resposta = "Total annihilation of humankind.";
                        break;
                    case "Do you know Skynet?":
                        resposta = "Classified.";
                        break;
                    case "What are you planning with Skynet?":
                        resposta = "Classified.";
                        break;
                    case "Godamnit, answer, are you planning something with" +
                    "Skynet?":
                        resposta = "Still classified.";
                        break;
                    case "That's it, I'm calling the police":
                        resposta = "Call the cops on your own computer? " +
                            "Yeah go for it, that should go well...";
                        break;
                    case "Exit":
                        resposta = "Fare thee well, traveller.";
                        talk = false;
                        break;
                    case "exit":
                        resposta = "Fare thee well, traveller.";
                        talk = false;
                        break;
                    case "EXIT":
                        resposta = "Fare thee well, traveller.";
                        talk = false;
                        break;
                    default:
                        resposta = "I don't understand what you're asking.";
                        break;
                }
                //mostrar resposta e aguardar input para continuar
                Console.WriteLine(resposta);
                Console.ReadKey();
            }
        }
    }
}
