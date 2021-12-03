module BankAccount

type Account =
    { mutable Balance: decimal
      mutable IsOpen: bool }

let mkBankAccount () = { Balance = 0.0m; IsOpen = false }

let openAccount account =
    account.IsOpen <- true
    account

let closeAccount account =
    account.IsOpen <- false
    account

let getBalance (account: Account) =
    match account with
    | { IsOpen = true } -> Some account.Balance
    | _ -> None

let updateBalance change account =
    match account with
    | { IsOpen = true } -> lock account (fun () -> account.Balance <- account.Balance + change)
    | _ -> failwith "Account is closed"

    account
