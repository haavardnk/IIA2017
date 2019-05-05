using System;
using NationalInstruments.Net;

namespace Controller
{
    public class Opc
    {
        private readonly DataSocket _dataSocket = new DataSocket();
        private readonly string _opcUrl;

        public Opc(string opcUrl)
        {
            _opcUrl = opcUrl;
        }

        public void SetOpcValue(double value)
        {
            _dataSocket.Connect(_opcUrl, AccessMode.Write);
            _dataSocket.Data.Value = value;
            _dataSocket.Update();
            _dataSocket.Disconnect();
        }
    }
}