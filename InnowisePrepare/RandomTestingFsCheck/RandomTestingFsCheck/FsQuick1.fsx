#r "nuget:FsCheck"

open FsCheck

let revRevIsOrig (xs:list<int>) = List.rev(List.rev xs) = xs

Check.Quick revRevIsOrig

let revIsOrig (xs:list<int>) = List.rev xs = xs
Check.Quick revIsOrig