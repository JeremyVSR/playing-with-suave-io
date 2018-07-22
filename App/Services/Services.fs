namespace Services
open Suave
open Suave.Successful

module Sleep =
  let sleep milliseconds message: WebPart =
    fun (x : HttpContext) ->
      async {
        do! Async.Sleep milliseconds
        return! OK message x
      }