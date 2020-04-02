namespace FSharpImplementationNamespace

module SeparatingAxisTheorem =
    let mathTest a b =
        (a * 2, b * 3)
    
    let argTest (xs : array<array<int>>) =
        printfn "%A" xs
        xs

