namespace TokenLimit.Domain

type TokenCount = 
    private TokenCount of uint

module TokenCount =
    let private validate count = 
        count > 0u

    let create count = 
        if validate count then
            Ok (TokenCount count)
        else
            Error "Token count must be greater than zero."

    let value (TokenCount count) = 
        count