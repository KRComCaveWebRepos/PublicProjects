using GameGenerator.Library.Interfaces;
using System;

namespace GameGenerator.Library.Models.Rainforest
{
    public class Camel : IAnimal
    {
        private readonly string _status = "Camel instantiated.";
        public Camel()
        {
            Console.WriteLine(this._status);
        }

        public string Status => this._status;

    }
}
