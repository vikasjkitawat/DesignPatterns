using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Directory : Resource
    {
        private string name;
        private List<Resource> childs;

        public Directory(string name)
        {
            this.name = name;
            this.childs = new List<Resource>();
        }

        public override bool IsDirectory => true;

        public override bool IsFile => false;

        public override string Name => this.name;

        public override List<Resource> GetChilds()
        {
            return this.childs;
        }

        public void AddChild(Resource child)
        {
            this.childs.Add(child);
        }
    }
}
