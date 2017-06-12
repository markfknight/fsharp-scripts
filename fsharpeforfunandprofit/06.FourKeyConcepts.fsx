let square x = x * x

// functions as values
let squareclone = square
let result = [1..10] |> List.map squareclone

// functions taking other functions as parameters
let execFunction aFunc aParam = aFunc aParam
let result2 = execFunction square 12


// Declare it
type IntAndBool = {intPart: int; boolPart: bool}
// use it
let x = {intPart = 1; boolPart = false}

// declare it
type IntOrBool =
    | IntChoice of int
    | BoolChoice of bool

// use it
let y = IntChoice 42
let z = BoolChoice true