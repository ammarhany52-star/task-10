using System.Collections;

public class ArrayListReverser
{
    public static void Reverse(ArrayList list)
    {
        int left = 0;
        int right = list.Count - 1;

        while (left < right)
        {
            object temp = list[left];

            list[left] = list[right];
            list[right] = temp;

            left++;
            right--;
        }
    }
}