using System;
using NationalInstruments.Net;

namespace Datalogging
{
    public class Opc
    {
        //Data types
        private readonly DataSocket _datasocket;
        private readonly string _opcUrl;

        public Opc(string opcUrl)
        {
            _opcUrl = opcUrl;
            _datasocket = new DataSocket();
        }


        public double GetOpcValue()
        {
            _datasocket.Connect(_opcUrl, AccessMode.Read);
            _datasocket.Update();
            var value = Convert.ToDouble(_datasocket.Data.Value);
            _datasocket.Disconnect();

            return value;
        }

        public double GetOpcQuality()
        {
            _datasocket.Connect(_opcUrl, AccessMode.Read);
            _datasocket.Update();
            var quality = Convert.ToDouble(_datasocket.Data.Attributes["Quality"].Value);
            _datasocket.Disconnect();

            return quality;
        }
    }
}
