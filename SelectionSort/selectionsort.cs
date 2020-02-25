using System;

namespace SelectionSort
{
    public class selectionsort
    {
        public static int[] seleSort(int[] array20)
        {
            int x, y, i_min;
            int temp;
            for(x=0;x<array20.Length-1;x++)
            {
                i_min = x;
                for(y=x+1;y<array20.Length;y++)
                {
                    if (array20[y] < array20[i_min])
                        i_min = y;
                }
                temp = array20[i_min];
                array20[i_min] = array20[x];
                array20[x] = temp;

            }
            return array20;
            
        }
    }
}
