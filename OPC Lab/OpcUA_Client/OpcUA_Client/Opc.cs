using System;
using System.Runtime.InteropServices;
using NationalInstruments.Net;

namespace OpcDA_Client
{
    public class Opc
    {
        private readonly DataSocket _dataSocket = new DataSocket();

        public bool Connect(string opcUrl)
        {
            if (_dataSocket.IsConnected)
            {
                this.Disconnect();
                return _dataSocket.IsConnected;
            }

            _dataSocket.Connect(opcUrl, AccessMode.Read);
            _dataSocket.Update();

            return _dataSocket.IsConnected;

        }

        public void Disconnect()
        {
            _dataSocket.Disconnect();
        }

        public double GetOpcValue()
        {
            _dataSocket.Update();
            return Convert.ToDouble(_dataSocket.Data.Value);
        }
    }
}