#r @"..\..\packages\FParsec\lib\net40-client\FParsecCS.dll"
#r @"..\..\packages\FParsec\lib\net40-client\FParsec.dll"
#load "FSONParser.fs"
open FSONParser

type Jurisdiction = 
    | BC | Alberta | Canada

type Address = 
    {Street: string;
    City: string; Region: Jurisdiction; 
    Postal: string option;
    Country: string;
    Northing: int16}

let data = "
Street: 245 West Howe
City: Vancouver
Region: BC
Country: Canada"

(parseFSON typeof<Address> data) :?> Address
