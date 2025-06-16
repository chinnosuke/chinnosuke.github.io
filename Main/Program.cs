// See https://aka.ms/new-console-template for more information

using System.IO;
using System.Collections.Concurrent;
using System.Text;
using Common;

namespace Ctest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var list = new List<List<sbyte>>();
            //list.Add(new List<sbyte>() { 1, 2, 3 });

            var array = new System.SByte[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,

            11,
            12,
            13,
            14,
            15,

            16,
            17,
            18,
            19,
            20,

            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            33,
            34,
            35,
            36,
            37

        };
            list = array.Combination(4).ToList();

            Console.WriteLine("List=" + list.Count);
            SaveCSV("./test.csv", list);
        }

        static void SaveCSV(string path, List<List<sbyte>> list)
        {
            StreamWriter sw = new StreamWriter(path, false);// TextData.txtというファイルを新規で用意
            foreach (var resList in list)
            {
                var sb = new StringBuilder();
                resList.ForEach(ii =>
                {
                    sb.Append($"{ii},");
                });
                sw.WriteLine(sb.ToString());
            }

            sw.Flush();// StreamWriterのバッファに書き出し残しがないか確認
            sw.Close();// ファイルを閉じる
        }
    }
}