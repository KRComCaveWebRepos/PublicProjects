using GameGenerator.Library.Interfaces;
using System;

namespace GameGenerator.Library.Models.Rainforest
{
    public class Gras : IUnderground
    {
        private readonly string _status = "Gras instantiated.";

        public Gras()
        {
            Console.WriteLine(this._status);
        }

        public string Status => this._status;

    }
}
