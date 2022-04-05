string[] array = { "hello", "--2", "word", "(-)" };
void finder(string[] finded)
{
    int j = 0;
    for (int i = 0; i < finded.Length; i++)
    {
        for (j = 0; j < finded[i].Length; j++)
        {

        }
        if (j <= 3)
        {
            Console.WriteLine(finded[i]);
        }

    }
}
finder(array);


 void finder2(string[] finded)
{

    for (int i = 0; i < finded.Length; i++)
    {

        if (finded[i].Length <= 3)
        {
            Console.WriteLine(finded[i]);
        }

    }
}
finder2(array);
