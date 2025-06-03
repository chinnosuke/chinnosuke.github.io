// See https://aka.ms/new-console-template for more information

using System.IO;
using System.Collections.Concurrent;
using System.Text;

namespace Ctest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var list = new List<List<sbyte>>();
            list.Add(new List<sbyte>() { 1, 2, 3 });
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