using GameGenerator.Library.Interfaces;
using System;

namespace GameGenerator.Library.Models.Rainforest
{
    public class Snow : IUnderground
    {
        private readonly string _status = "Snow instantiated.";

        public Snow()
        {
            Console.WriteLine(this._status);
        }

        public string Status => this._status;

    }
}
