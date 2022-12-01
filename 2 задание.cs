void Get_and_Print_Array() 
{
   
    int[] array = new int[8];
    for(int i = 0;i<8;i++)
    {
        System.Console.WriteLine("Введите "+ i + "-ое число");
        array[i] = int.Parse(Console.ReadLine());
    }
    for(int i = 0;i<8;i++)
    {
        System.Console.Write(array[i] + " ");
    }
   
}
Get_and_Print_Array();

