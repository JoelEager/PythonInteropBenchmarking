namespace FSharpImplementationNamespace

module SeparatingAxisTheorem =
    let mathTest a b =
        a * 2, b * 3

    let typeTest (values: array<array<int>>) =
        printfn "%A" values
        values

    let maxArray (values: array<int>) =
        let mutable maxValue = values.[0]

        for value in values do
            if maxValue < value then maxValue <- value

        maxValue

    let minArray (values: array<int>) =
        let mutable minValue = values.[0]

        for value in values do
            if minValue > value then minValue <- value

        minValue

    let edgeVector (point1: array<int>) (point2: array<int>) =
        point2.[0] - point1.[0], point2.[1] - point1.[1]

    let polyToEdges (poly: array<array<int>>) =
        [| for i in 0 .. poly.Length - 1 do
            yield edgeVector poly.[0] poly.[(i + 1) % poly.Length] |]

    let orthogonal vector =
        snd vector, -fst vector

    let dotProduct vector1 vector2 =
        fst vector1 * fst vector2 + snd vector1 * snd vector2

    let project (poly: array<array<int>>) axis =
        let dots =
            [| for point in poly do
                yield dotProduct (point.[0], point.[1]) axis |]
        minArray dots, maxArray dots

    let overlap (projection1: int * int) (projection2: int * int) =
        min (fst projection1) (snd projection1) <= max (fst projection2) (snd projection2)
        && min (fst projection2) (snd projection2) <= max (fst projection1) (snd projection1)

    let hasCollied (poly1: array<array<int>>) (poly2: array<array<int>>) =
        let edges =
            Array.concat
                [ polyToEdges poly1
                  polyToEdges poly2 ]
        let axes =
            [| for edge in edges do
                yield orthogonal edge |]

        let mutable overlapping = true

        for axis in axes do
            if overlapping then overlapping <- overlap (project poly1 axis) (project poly2 axis)

        overlapping
