using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksApplication
{
    public class MyNode : TreeNode
    {
        // реализация TreeNode с добавлением типа и id
        public Type TypeProperty { get; set; }
        public int Id { get; set; }

        public MyNode(){}

        public MyNode(string node_text, Type type, int id)
        {
            Text = node_text;
            TypeProperty = type;
            Id = id;

        }  

        
    }
}
