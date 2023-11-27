using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public enum Personnel
    {
        // Creeating different type of classes are called nested types
        Caterers,
        EventManagement,
        Engineers,
        Lawyers,
        Designers,
        ProjectManager,
    }
    public struct Structure
    {
        //Struct is a class, it encapsulate data and deleted functions. They are majoly use for  writing data (info about someone) and they keep data in check.
        private int _structureid;// fields
        private string _name;
        private Qualification _qualification;
        private Personnel _personnel;

        public int Structureid
        {
            get => _structureid;
            set => _structureid = value;
        }
        public string Name
        {
            get => _name; //Properties
            set => _name = value;
        }
        public Qualification Qualification
        {
            get => _qualification;
            set => _qualification = value;
        }
        public Personnel Personnel
        {
            get => _personnel;
            set => _personnel = value;
        }
        public Structure(int id , string name, Qualification qualification, Personnel personnel) // constructor
        {
            _name = name;
            _structureid = id;
        }
        public void PrintInfo() //method
        {
            Console.WriteLine("The name assigned to the building structure is.......{0} and id is ......{1}, the personnel needed in this buildings are {2} with {3} qualifications", _name, _structureid, _personnel, _qualification);
        }
    }
}
