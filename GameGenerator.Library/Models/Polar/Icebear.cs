using GameGenerator.Library.Interfaces;
using System;

namespace GameGenerator.Library.Models.Rainforest
{

    public class Icebear : IAnimal
    {
        private readonly string _status = "Icebear instantiated.";

        public Icebear()
        {
            Console.WriteLine(this._status);
        }

        public string Status => this._status;


    }
}
