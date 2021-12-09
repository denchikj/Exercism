module RotationalCipher

open System

let rotate shiftKey (text: string) =
    match shiftKey with
    | 0
    | 26 -> text
    | _ ->
        String.map
            (fun x ->
                if Char.IsLetter x then
                    let lastLetter = if Char.IsUpper x then 'Z' else 'z'
                    let shifted = int x + shiftKey

                    if int lastLetter >= shifted then
                        char shifted
                    else
                        shifted - 26 |> char
                else
                    x)
            text
