
open Suave
open Suave.Operators
open Suave.Filters
open Suave.Successful
open Services.Sleep
let app =
  choose
    [ GET >=> choose
        [ path "/hello" >=> sleep 100 "OK Sleep"
          path "/goodbye" >=> OK "Good bye GET" ]
      POST >=> choose
        [ path "/hello" >=> OK "Hello POST"
          path "/goodbye" >=> OK "Good bye POST" ] ]

startWebServer defaultConfig app