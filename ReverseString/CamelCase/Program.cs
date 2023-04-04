namespace CamelCase
{
    internal class Program
    {
        static void convert(String s)
        {
            int n = s.Length;
            char[] ch = s.ToCharArray();
            int res_ind = 0;
            for(int i = 0; i < n; i++)
            {
                if (ch[i] == ' ')
                {
                    ch[i + 1] = char.ToUpper(ch[i + 1]);
                    continue;
                }
                else
                {
                    ch[res_ind++] = ch[i];
                }
                Console.Write(ch[i]);
            }
        }
        public static void Main(string[] args)
        {
            String str = "hi everyone!";
            convert(str);
        }
    }
}