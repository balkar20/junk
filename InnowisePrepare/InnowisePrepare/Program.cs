// See https://aka.ms/new-console-template for more information

using InnowisePrepare;

var id = Guid. NewGuid(); 
Console.WriteLine(id);

var base64Id = Convert.ToBase64String (id. ToByteArray()); Console.WriteLine(base64Id);
var urlFriendlyBase64Id = AllocTest.ToStringFromGuid(id); Console.WriteLine(urlFriendlyBase64Id);

var idAgain = AllocTest.ToGuidFromString (urlFriendlyBase64Id); 
var idAgainOp = AllocTest.ToGuidFromStringOp (urlFriendlyBase64Id); 

Console.WriteLine(idAgain); 
Console.WriteLine(idAgainOp); 