using System;

namespace CSharp_Advance_Programming.NUnit.DatabaseConnection
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; }

        public void Connect()
        {
            IsConnected = true;   // Simulate opening a connection
        }

        public void Disconnect()
        {
            IsConnected = false;  // Simulate closing a connection
        }
    }

}
