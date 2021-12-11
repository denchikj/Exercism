module Sublist

type SublistType =
    | Equal
    | Sublist
    | Superlist
    | Unequal

let rec sublistOf xs ys =
    match (xs, ys) with
    | ([], _) -> true
    | (x :: xtail, y :: ytail) ->
        if x = y
           && xtail = (List.truncate (List.length xtail) ytail) then
            true
        else
            sublistOf xs ytail
    | _ -> false

let sublist xs ys =
    match (sublistOf xs ys, sublistOf ys xs) with
    | (true, true) -> Equal
    | (true, false) -> Sublist
    | (false, true) -> Superlist
    | (false, false) -> Unequal
