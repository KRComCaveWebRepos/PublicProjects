using GameGenerator.Library.Interfaces;
using System;

namespace GameGenerator.Library.Models.Rainforest
{
    public class Elephant : IAnimal
    {
        private readonly string _status = "Elephant instantiated.";

        public Elephant()
        {
            Console.WriteLine(this._status);
        }

        public string Status => this._status;

    }
}
