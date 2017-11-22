using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Logica;

namespace Tests
{

    [TestClass]
    public class UnitTestAhorcado
    {
        Juego juego = new Juego();

        public bool ArriesgarPalabra(string palabra)
        {
            bool respuesta = juego.Arriesgar(palabra);
            return respuesta;
        }

        [TestMethod]
        public void ArriesgarPalabraCorrectaTest()
        {
            //Arrange
            juego.Palabra = "arriesgar";

            //Act
            bool respuesta = ArriesgarPalabra("arriesgar");


            //Assert
            Assert.AreEqual(respuesta, true);
        }

        [TestMethod]
        public void ArriesgarPalabraIncorrectaTest()
        {
            //Arrange
            juego.Palabra = "arriesgar";

            //Act
            bool respuesta = ArriesgarPalabra("arrisegar");


            //Assert
            Assert.AreEqual(respuesta, false);
        }

        [TestMethod]
        public void IngresarPalabraTest()
        {
            juego.IngresarPalabra("palabra");

            Assert.AreEqual("palabra", juego.Palabra);
        }

        [TestMethod]
        public void ContarIntentosTest()
        {
            juego.IngresarPalabra("palabra");
            for (int i = 0; i < 5; i++)
            {
                ArriesgarPalabra("arrisegar");
            }

            Assert.AreEqual(5, juego.Intentos);
        }

        [TestMethod]
        public void ArriesgarLetraCorrectaTest()
        {
            juego.IngresarPalabra("palabra");
            //juego.Palabra.ToCharArray();
            bool rta = juego.ArriesgarLetra('a');
            Assert.AreEqual(rta, true);
        }

        [TestMethod]
        public void ArriesgarLetraIncorrectaTest()
        {
            juego.IngresarPalabra("palabra");
            //juego.Palabra.ToCharArray();
            bool rta = juego.ArriesgarLetra('i');
            Assert.AreEqual(rta, false);
        }

        [TestMethod]
        public void ArriesgarLetraCorrectaYVerProgresoTest()
        {
            juego.IngresarPalabra("palabra");
            juego.ArriesgarLetra('b');
            char[] temp = { '_', '_', '_', '_', 'b', '_', '_' };
            CollectionAssert.AreEqual(juego.Letras, temp);
        }

        [TestMethod]
        public void ArriesgarLetraIncorrectaCincoIntentosTest()
        {
            juego.IngresarPalabra("palabra");

            for (int i = 0; i < 5; i++)
            {
                juego.ArriesgarLetra('i');
            }

            Assert.AreEqual(5, juego.Intentos);
        }
    }
}
