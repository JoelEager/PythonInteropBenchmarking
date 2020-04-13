namespace FSharpImplementationNamespace

module SeparatingAxisTheorem =
    let mathTest a b =
        (a * 2, b * 3)
    
    let argTest (xs : array<array<int>>) =
        printfn "%A" xs
        xs

    let hasCollied (poly1 : array<array<int>>) (poly2 : array<array<int>>) =
        printfn "%A" poly1
        printfn "%A" poly2
        true
