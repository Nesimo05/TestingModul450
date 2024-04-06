
using FahrzeugVerwaltung.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrzeugVerwaltungSolution.Mock
{
    public class FahrzeugMock : IFahrzeug
    {
        public int Capacity { get; set; } = 10; // Maximalanzahl der Behälter

        public bool HasEnoughSpace(int containerCount)
        {
            return containerCount <= Capacity;
        }

        public bool AcceptOrder(IAuftrag order)
        {
            // Akzeptiere den Auftrag nur, wenn genügend Platz vorhanden ist
            return HasEnoughSpace(order.AnzahlContainer);
        }

    }
}