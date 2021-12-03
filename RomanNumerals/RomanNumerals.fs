module RomanNumerals

let numbersToRomans =
    [ 1, "I"
      4, "IV"
      5, "V"
      9, "IX"
      10, "X"
      40, "XL"
      50, "L"
      90, "XC"
      100, "C"
      400, "CD"
      500, "D"
      900, "CM"
      1000, "M" ]
    |> List.rev

let convert number =
    numbersToRomans
    |> List.tryFind (fun n -> number >= fst n)

let rec roman arabicNumeral : string =
    match (arabicNumeral, convert arabicNumeral) with
    | (0, _)
    | (_, None) -> ""
    | (n, c) -> snd (c.Value) + roman (n - fst c.Value)
