module PizzaPricing

// TODO: please define the 'Pizza' discriminated union type
type Pizza = 
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza): int = 
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce es -> pizzaPrice es + 1
    | ExtraToppings et -> pizzaPrice et + 2

let orderPrice(pizzas: Pizza list): int = 
    let sum = Seq.sumBy pizzaPrice pizzas 
    match pizzas.Length with
    | 1 -> sum + 3
    | 2 -> sum + 2
    | _ -> sum
