//000056789012345 antwoord is 215 controle getal is 5
//999225473294617 antwoord is 484 controle getal is 0
//(11 - (temp_result % 11))
// 10 = 1
// 11 = 0

let _Gewichten = [| 2;4;8;5;10;9;7;3;6;1;2;4;8;5;10 |] 
let _15Cijfer =  "999225473294617"
let _15CijferArray = _15Cijfer.ToCharArray() |> Array.rev 

let Kenmerk (input:char[]):string = 
    let mutable sum = 0
    for i = 0 to input.Length - 1 do
        sum <- sum + (int(string(input.[i])) * _Gewichten.[i])

    let mutable result = ""
    if (11 - (sum % 11)) = 10 then result <- "1"+_15Cijfer
    elif (11 - (sum % 11)) = 11 then result <- "0"+_15Cijfer
    else result <- string((11 - (sum % 11)))+_15Cijfer

    result

[<EntryPoint>]
let main argv = 
    printfn "Acceptgiro Met Controle Getal : %A" (Kenmerk _15CijferArray)
    argv
    System.Console.ReadKey() |> ignore
    0