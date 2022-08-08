int[] array = {1, 12, 14,421, 331 ,31, 34};
int n = array.Length;
int find = 14;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;

    }
    //index = index +1;
    index++;
}