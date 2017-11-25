module Runner

open System.Net.Http
open Microsoft.Azure.WebJobs

let run ( req : HttpRequestMessage ) =
  async {
     let! content = Main.main ()
     return new HttpResponseMessage ( Content = new StringContent ( content ) )
  } |> Async.StartAsTask
