module ValentinesDay

// TODO: please define the 'Approval' discriminated union type
type Approval =
    | Yes
    | No
    | Maybe
// TODO: please define the 'Cuisine' discriminated union type
type Cuisine =
    | Korean
    | Turkish
// TODO: please define the 'Genre' discriminated union type
type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller
// TODO: please define the 'Activity' discriminated union type
type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity) : Approval =
    match activity with
    | BoardGame -> No
    | Chill -> No
    | Movie x ->
        match x with
        | Romance -> Yes
        | _ -> No
    | Restaurant x ->
        match x with
        | Korean -> Yes
        | Turkish -> Maybe
    | Walk x ->
        match x with
        | x when x < 3 -> Yes
        | x when x >= 3 && x < 5 -> Maybe
        | _ -> No
