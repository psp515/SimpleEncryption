using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.ConsoleOperating.Interface
{
    interface IDE
    {
        public void StartProcess();
        public void GetMessage();
        public string Message { get; set; }
        public string FullCode { get; set; }
    }
}
