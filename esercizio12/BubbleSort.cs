using System;

namespace ClassLibrary
{
    public class BubbleSort
    {
        public static int[] Bubblesort(int []array20)
        {
            int x;
            int y;
            int temp;
            for(x=0;x<array20.Length-1;x++)
            {
                for(y=0;y<array20.Length-1;y++)
                {
                    if(array20[y]>array20[y+1])
                    {
                        temp = array20[y];
                        array20[y] = array20[y + 1];
                        array20[y + 1] = temp;
                    }
                }
            }
            return array20;
        }
    }
}
