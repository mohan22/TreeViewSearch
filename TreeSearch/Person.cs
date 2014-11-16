using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace TreeSearch
{
    class Person
    {
        readonly ObservableCollection<Person> _children = new ObservableCollection<Person>();
        public IList<Person> Children
        {
            get { return _children; }
        }
        // public ObservableCollection<Person> Children { get; set; }

        public string Name { get; set; }
    }
}
