internal class Program
{
    private static void Main(string[] args)
    {
        int[,] a = new int[5,5];
        Random n= new Random();

        for (int l=0; l<a.GetLength(0); l++)
        {
            for(int c=0; c<a.GetLength(1); c++)
            {
                a[l, c] = n.Next(100);
            }
        }
        SomaColuna(a);
        SomaLinha(a);
        SomaDiagonalPrincipal(a);
        SomaDiagonalSecundaria(a);

        for (int l = 0; l < a.GetLength(0); l++)
        {
            for (int c = 0; c < a.GetLength(1); c++)
            {
                Console.Write(a[l,c]+" ");
            }
            Console.WriteLine();
        }

        void SomaColuna(int[,] a)
        {
            int[] v= new int[a.GetLength(1)];
            for (int l = 0; l < a.GetLength(0); l++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    v[c] += a[l, c];
                }
            }
            
            for(int i=0; i<v.Length; i++)
            {
                Console.WriteLine("Soma da coluna "+i+" "+v[i]);
            }
        }


        void SomaLinha(int[,] a)
        {
            int[] v = new int[a.GetLength(0)];
            for (int l = 0; l < a.GetLength(0); l++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    v[l] += a[l, c];
                }
            }

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("Soma da linha " + i + " " + v[i]);
            }
        }

        void SomaDiagonalPrincipal(int[,] a)
        {
            int v=0;
            for (int l = 0; l < a.GetLength(0); l++)
            {
                v += a[l,l];
            }

            Console.WriteLine("Soma da diagonal principal  " + v);
        }


        void SomaDiagonalSecundaria(int[,] a)
        {
            int v = 0;
            for (int l = 0; l < a.GetLength(0); l++)
            {
                v += a[l, (a.GetLength(0)-1)-l];
            }

            Console.WriteLine("Soma da diagonal secundaria  " + v);
        }
    }
}