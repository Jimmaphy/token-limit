namespace TokenLimit

open TokenLimit.Domain

module Program = 
    match TokenCount.create 5u with
    | Ok tokenCount ->
        tokenCount
        |> TokenCount.value
        |> printfn "Token count: %u"
    
    | Error message ->
        printfn "Could not create token count: %s" message