using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Student
    {
        protected string _name, _function;
        public string name  { get { return _name; } }
        public string function { get { return _function; } set { _function = value; } }
        protected int _leadership, _responsibility, _programming, _designe, _lvl;
        public int leadership { get { return _leadership; } }
        public int responsibility { get { return _responsibility; } }
        public int programming { get { return _programming; } }
        public int designe{ get { return _designe; } }
        public int lvl { get { return _lvl; } }

        Random rand = new Random();

        public void InitStudent(string name, string function)
        {

            this._name = name;
            this._function = function;
            this._lvl = 1;
            this._leadership = rand.Next(1, 101);
            this._responsibility = rand.Next(1, 101);
            this._programming = rand.Next(1, 101);
            this._designe = rand.Next(1, 101);
        }

        public void LvlUp(int lead, int resp, int prog, int des)
        {
            this._lvl++;
            this._leadership += lead;
            this._responsibility += resp;
            this._programming += prog;
            this._designe += des;
        }
        
        public string GetData()
        {
            return ("Name: " + this.name + "\n" + "Function: " + this.function + "\n" + "Lvl: " + this.lvl + "\n" + "Leadership: " + this.leadership +
                "\n" + "Responsibility: " + this.responsibility + "\n" + "Programming: " + this.programming + "\n" + "Designe: " + this.designe);
        }
    }
}
