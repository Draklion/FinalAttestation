Console.Write("Введите количество элементов массива: ");

int number = Int32.Parse(Console.ReadLine());
string[] array = new string[number];
string[] result = new string[number];
int count = 0;
if (number <= 0) Console.WriteLine("Количество элементов массива не может быть меньше нуля.");
else
{
  Console.WriteLine("Введите элементы массива:");

  for (int i = 0; i < array.Length; i++) array[i] = Console.ReadLine();

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].ToString().Length <= 3)
    {
      result[count] = array[i];
      count++;
    }
  }


  if (count == 0) Console.WriteLine("В массиве нет элементов, в которых строка менее трех символов.");
  else
  {
    Console.Write("Результирующий массив: ");
    for (int i = 0; i < count; i++) Console.Write(result[i] + " ");
  }
}