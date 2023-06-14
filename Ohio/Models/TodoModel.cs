using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestDesign.Models
{
    class TodoModel
    {
        private string _text;
        private bool _isDone;
        public DateTime CreationDate { get; set; } = DateTime.Now;





        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }



        
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }



    }
}
