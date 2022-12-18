namespace Advanced_DSA.Problems.Bit_Manipulation;

public static class NPlus2
{
    private static readonly int N = 9;
    private static readonly int[] A = new int[] { 1, 2, 4, 5, 7, 8, 9, 10, 11 };

    public static int[] Missing2Numbers()
    {
        int[] temp = new int[N + N + 2];
        int cnt = 0;

        for(int i = 0; i < A.Length; i++)
        {
            temp[cnt] = A[i];
            cnt++;
        }

        for(int i=1; i<=(A.Length+2); i++)
        {
            temp[cnt] = i;
            cnt++;
        }

        int XOR = 0;
        for(int i=0; i<temp.Length; i++)
        {
            XOR = XOR ^ temp[i];
        }

        int pos = -1;
        for(int i=0; i<32; i++)
        {
            if((XOR & (1<<i)) > 0)
            {
                pos = i; break;
            }
        }

        int X = 0, Y = 0;
        for(int i=0; i<temp.Length; i++)
        {
            if ((temp[i] & (1 << pos)) > 0) X = X ^ temp[i];
            else Y = Y ^ temp[i];
        }

        return new int[2] { X, Y };
    }
}
