module TisburyTreasureHunt

let getCoordinate (line: string * string): string = snd line

let convertCoordinate (coordinate: string): int * char = 
    ((coordinate.[0] |> string |> int), coordinate.[1])

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    let tc = azarasData |> getCoordinate |> convertCoordinate
    let _, lcq, _ = ruisData
    tc = lcq

let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    if compareRecords azarasData ruisData then
        let (treasure, coordinate) = azarasData
        let (location, _, quadrant) = ruisData
        (coordinate, location, quadrant, treasure)
    else 
        ("", "", "", "")