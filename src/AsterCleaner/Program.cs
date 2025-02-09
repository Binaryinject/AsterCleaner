using System.Diagnostics;
using Microsoft.Win32;


if (Directory.Exists(@"C:\ProgramData\ASTER Control")) Directory.Delete(@"C:\ProgramData\ASTER Control", true);

const string keyPath = @"SOFTWARE\IBIK\ASTER\asterctx";
var key = Registry.LocalMachine.OpenSubKey(keyPath, true);
if (key != null) Registry.LocalMachine.DeleteSubKeyTree(keyPath);

Process.Start("SecHex-Spoofy/SecHex-GUI.exe");
