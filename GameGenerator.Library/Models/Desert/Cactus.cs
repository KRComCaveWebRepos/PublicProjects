using GameGenerator.Library.Interfaces;
using System;

namespace GameGenerator.Library.Models.Rainforest
{
    public class Cactus : IPlant
    {
        private readonly string _status = "Cactus instantiated.";

        public Cactus()
        {
            Console.WriteLine(this._status);
        }

        public string Status => this._status;
    }
}
