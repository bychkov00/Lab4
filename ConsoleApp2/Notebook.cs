using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Input;

namespace Notebook1
{
    class Notebook
    {
	private List<string> notes = new List<string>() { "Пойти на работу", "Пойти на пару" };
	public bool xinterface = false;

        public void Help()
        {
            Console.WriteLine("Для добавления новой записи введите 'a' и новую запись через пробел");
            Console.WriteLine("Для удаления записи введите 'd' и номер записи через пробел");
            Console.WriteLine("Для отображения всех записей введите 'l'");
            Console.WriteLine("Для отображения подсказки введите 'h'");
            Console.WriteLine("Для завершения работы введите 'q'");
            Console.WriteLine("Для трехкнопочного интерфейса введите 'x'");
            Console.WriteLine(new string('_', Console.WindowWidth));
        }

        public void Help2()
        {
            Console.WriteLine("Для добавления новой записи введите 'a' и новую запись через пробел");
            Console.WriteLine("Для удаления записи введите 'd' и номер записи через пробел");
            Console.WriteLine("Для завершения работы введите 'q'");
            Console.WriteLine("Для переключения в обычный интерфейс введите 'x'");
            Console.WriteLine(new string('_', Console.WindowWidth));
        }

        public void AddNote(string comand)
        {
            var str = comand.Substring(1).Trim();
            if (str.Length > 0 && str != null)
            {
                notes.Add(str);
                Console.WriteLine("Запись добавлена");
            }
            else
                Console.WriteLine("Строка не распознана");
        }

        public void DeleteNote(string comand)
        {
            var str = comand.Substring(1).Trim();
            var number = 0;
            try
            {
                number = int.Parse(str);
            }
            catch
            {
                Console.WriteLine("Номер записи не распознан");
                return;
            }
            if (number <= notes.Count && number >= 1)
            {
                notes.RemoveAt(number - 1);
                Console.WriteLine("Запись удалена");
            }
            else
                Console.WriteLine("Номер записи не найден");
        }

        public void ShowNotes()
        {
            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine(i + 1 + " " + notes[i]);
            }
        }
    }
}