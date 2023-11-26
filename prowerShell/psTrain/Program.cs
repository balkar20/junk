// See https://aka.ms/new-console-template for more information

using System.Management.Automation;

using PowershellShowcase;

var parameters = new Dictionary<string, string>()
{
    { "$help", "firshelpt" },
    { "pod", "secondpod" },
};

// var arguments = new List<string>()
// {
//     { "firshelpt" },
//     { "secondpod" }
// };

string script = File.ReadAllText("testPs.ps1");
// string outputSetPolicy = PowerShellHandler.Command("Set-ExecutionPolicy -ExecutionPolicy RemoteSigned");
string output = PowerShellHandler.Command("C:\\Preparation\\prowerShell\\psTrain\\testPs.ps1 ik ol ko ");

// Console.WriteLine(outputSetPolicy);
Console.WriteLine(output);
Console.ReadLine();
// var parameters = new Dictionary<string, string>()
// {
//     { "help", "firshelpt" },
//     { "pod", "secondpod" },
// };

// string script = File.ReadAllText("testPs.ps1");
// PowerShell ps = PowerShell.Create();
// ps.AddCommand("Get-Process");
// ps.Invoke();
// var f = PowerShell.Create().AddScript(script);
//
// var ires =f
//     .AddParameters(parameters)
//     .AddArgument("onw")
//     .AddArgument("two")
//     .AddArgument("three")
//     .BeginInvoke();
// ires.AsyncWaitHandle()
// var info = f.InvocationStateInfo;
// var err = info.State == PSInvocationState.Failed;
// Console.WriteLine(info);
// Console.WriteLine(err);
// // var errReason = info.Reason;
// //
// // Console.WriteLine($"result: {errReason.ToString()}");
//
// foreach (PSObject p in res)
// {
//     Console.WriteLine(p.ToString());
// }
// Console.WriteLine("Press any key to continue");
// Console.ReadLine();
//
// Console.ReadLine();