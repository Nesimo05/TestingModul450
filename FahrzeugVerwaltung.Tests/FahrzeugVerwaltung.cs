using FahrzeugVerwaltungSolution.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FahrzeugVerwaltung.Interfaces;
using FahrzeugVerwaltungSolution.Mocks;



namespace FahrzeugVerwaltungSolution.Interfaces
{
        public class FahrzeugTests
        {
            [Fact]
            public void ShouldAcceptOrderWhenEnoughSpace()
            {
                // Arrange
                var fahrzeug = new FahrzeugMock { Capacity = 10 };
                var order = new AuftragMock { AnzahlContainer = 5 };

                // Act
                var result = fahrzeug.AcceptOrder(order);

                // Assert
                Assert.True(result, "Fahrzeug sollte den Auftrag annehmen, wenn genug Platz vorhanden ist.");
            }

            [Theory]
            [InlineData(11)]
            [InlineData(15)]
            public void ShouldRejectOrderWhenNotEnoughSpace(int containerCount)
            {
                // Arrange
                var fahrzeug = new FahrzeugMock { Capacity = 10 };
                var order = new AuftragMock { AnzahlContainer = containerCount };

                // Act
                var result = fahrzeug.AcceptOrder(order);

                // Assert
                Assert.False(result, "Fahrzeug sollte den Auftrag ablehnen, wenn nicht genug Platz vorhanden ist.");
            }

            // Hier könnten weitere Testmethoden hinzugefügt werden, z. B. für Negativ-Szenarien
        }
    }

