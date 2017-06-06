using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory root = new Directory("mydir");

            File file1 = new File("Doc1.txt");
            File file2 = new File("Doc2.txt");
            Directory dir1 = new Directory("Dir1");
            Directory dir2 = new Directory("Dir2");
            Directory dir3 = new Directory("Dir3");

            root.AddChild(file1);
            root.AddChild(file2);
            root.AddChild(dir1);
            root.AddChild(dir2);
            root.AddChild(dir3);

            File file3 = new File("Doc3.txt");
            dir1.AddChild(file3);

            PrintNodes(root);
            Console.ReadKey();
        }

        private static void PrintNodes(Resource node)
        {
            Console.WriteLine(node.Name + " - " + (node.IsDirectory ? "Dir" : "File"));

            if (node.GetChilds() != null && node.GetChilds().Count > 0)
            {
                foreach (var child in node.GetChilds())
                {
                    PrintNodes(child);
                }
            }
        }
    }
}

