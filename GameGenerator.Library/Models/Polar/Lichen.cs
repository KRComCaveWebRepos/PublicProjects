using GameGenerator.Library.Interfaces;
using System;

namespace GameGenerator.Library.Models.Rainforest
{
    public class Lichen : IPlant
    {
        private readonly string _status = "Lichen instantiated.";

        public Lichen()
        {
            Console.WriteLine(this._status);
        }

        public string Status => this._status;

    }
}
