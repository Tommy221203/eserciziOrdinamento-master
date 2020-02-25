using System;

namespace ScambioSentinella
{
    public class Sentinellascambio
    {
        public static int[] Sentinella(int[]array20)
        {
            int y;
            int temp;
            bool scambi = false;
            do
            {
                scambi = false;
                for (y = 0; y < array20.Length - 1; y++)
                {
                    if (array20[y] > array20[y + 1])
                    {
                        temp = array20[y];
                        array20[y] = array20[y + 1];
                        array20[y + 1] = temp;
                        scambi = true;
                    }
                }
            } while (scambi == true);
            return array20;

        }
    }
}
