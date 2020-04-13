namespace FSharpImplementationNamespace

module SeparatingAxisTheorem =
    let mathTest a b =
        a * 2, b * 3

    let typeTest (values: array<array<int>>) =
        printfn "%A" values
        values

    let max (values: array<int>) =
        let mutable maxValue = values.[0]

        for value in values do
            if maxValue < value then maxValue <- value

        maxValue

    let min (values: array<int>) =
        let mutable minValue = values.[0]

        for value in values do
            if minValue > value then minValue <- value

        minValue

    let edgeVector (point1: array<int>) (point2: array<int>) =
        point2.[0] - point1.[0], point2.[1] - point1.[1]

    let polyToEdges (poly: array<array<int>>) =
        [ for i in 0 .. poly.Length - 1 do
            yield edgeVector poly.[0] poly.[(i + 1) % poly.Length] ]

    let orthogonal (vector: array<int>) =
        vector.[1], -vector.[0]

    let dotProduct (vector1: array<int>) (vector2: array<int>) =
        vector1.[0] * vector2.[0] + vector1.[1] * vector2.[1]

    let project poly axis =
        let dots = [for point in poly do yield dotProduct point axis]
        min dots, max dots

    let hasCollied (poly1: array<array<int>>) (poly2: array<array<int>>) =
        printfn "%A" poly1
        printfn "%A" poly2
        true
