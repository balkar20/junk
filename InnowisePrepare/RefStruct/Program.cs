// See https://aka.ms/new-console-template for more information

using System.Text;
using RefStruct;

StringExample();

static void StringExample()
{
    var stringHolder = new StringHolder();
    stringHolder.Value += "Hello";
    AppendWorld(ref stringHolder);
    
    Console.WriteLine(stringHolder);
    
    void AppendWorld(ref StringHolder str)
    {
        // str = new StringHolder();
        str.Value += " world";
    }
}