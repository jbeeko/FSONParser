#r @"../build/FParsecCS.dll"
#r @"../build/FParsec.dll"
#load @"../src/FSONParser/FSONParser.fs"

open FSONParser

type Jurisdiction = 
    | BC | Alberta | Canada

type Address = 
    {Number: int16;
    Street: string;
    City: string; Region: Jurisdiction; 
    Postal: string option;
    Country: string;}

let data = "
-   Number: 3670
    Street: 245 West Howe
    City: Vancouver
    Region: BC
    Country: Canada
-   Number: 3670
    Street: 245 West Howe
    City: Vancouver
    Region: BC
    Country: Canada

"

let address = (parseFSON typeof<Address list> data) :?> Address list
