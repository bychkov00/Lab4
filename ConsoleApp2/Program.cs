using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Input;
using Notebook1;

namespace Lab3
{
    internal class Program
    {
        static void Main()
        {
            Notebook noteb = new Notebook();
            bool quit = false;

            noteb.Help();

            while (!quit)
            {
                Console.WriteLine("");
                Console.WriteLine("Введите команду:");
                Console.WriteLine("");
                var comand = Console.ReadLine();
                if (comand.Length == 0 || comand == null)
                    continue;
                switch (comand[0])
                {
                    case 'a':
                        {
                            noteb.AddNote(comand);
                            break;
                        }
                    case 'd':
                        noteb.DeleteNote(comand);
                        break;
                    case 'h':
                        {
                            if (!noteb.xinterface)
                                noteb.Help();
                            break;
                        }
                    case 'l':
                        {
                            if (!noteb.xinterface)
                                noteb.ShowNotes();
                            break;
                        }
                    case 'x':
                        {
                            if (noteb.xinterface)
                            {
                                noteb.xinterface = false;
                                Console.Clear();
                                noteb.Help();
                            }
                            else
                                noteb.xinterface = true;
                            break;
                        }
                    case 'q':
                        {
                            quit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Команда не распознана");
                            break;
                        }
                }
                if (noteb.xinterface)
                {
                    Console.Clear();
                    noteb.Help2();
                    Console.WriteLine();
                    noteb.ShowNotes();
                }
            }
        }
    }
}
