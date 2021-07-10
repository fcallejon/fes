namespace Fes.Contracts.Query.Booleans

type Must = class end

type Filter = class end

type Should = class end

type MustNot = class end

type BoolOptions =
    { MinimumShouldMatch: option<int>
      Boost: option<double> }

type Bool =
| Must of (Must * BoolOptions)
| Filter of (Filter * BoolOptions)
| Should of (Should * BoolOptions)
| MustNot of (MustNot * BoolOptions)