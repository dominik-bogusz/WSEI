using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{
    class ObservableList1<T>
    {
        public double Length { get; set; }



        public void Add()
        {

        }
        public void Get()
        {

        }
        public void Set()
        {

        }
        public void RemoveAt()
        {

        }

        private string[] strArr = new string[10];
        public string this[int index]
        {
            get
            {
                return strArr[index];
            }

            set
            {
                
            }
        }
    }
}
