module Acronym

let abbreviate (phrase: string) =
    [ for s in phrase.Split [| ' '; '-'; '_' |] -> s.[0..0].ToUpper() ]
    |> String.concat ""
