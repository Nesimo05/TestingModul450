using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FahrzeugVerwaltungSolution.Interfaces;

    namespace FahrzeugVerwaltung.Interfaces
    {
        public interface IFahrzeug
        {
            bool HasEnoughSpace(int containerCount);
            bool AcceptOrder(IAuftrag order);
            // Hier könnten weitere relevante Methoden und Eigenschaften definiert werden.
        }
    }


