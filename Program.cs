//c-sharp functions


//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
void StampaArray(int[] array) {
    Console.Write('[');
    for (int i = 0; i < array.Length; i++) {
        Console.Write(i == array.Length - 1 ? array[i] : array[i] + " , ");
    }
    Console.Write(']');
    Console.WriteLine();
}
//funzione genera quadrati
int Quadrato(int numero) {
    return (int)Math.Pow(numero, 2);
}
//funzione quadrati in array
int[] ElevaArrayAlQuadrato(int[] array) {
    int[] localArray = (int[])array.Clone();
    for (int i = 0; i < localArray.Length; i++) {
        localArray[i] = Quadrato(localArray[i]);
    }
    return localArray;
 }
//funzione somma elementi array
int sommaElementiArray(int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++) {
        sum += array[i];
    }
    return sum;
}
//array di test
//int[] test = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine("Inserire il numero di elementi dell'array");
int size = Convert.ToInt32(Console.ReadLine());
int[] test = new int[size];
for (int i = 0; i < test.Length; i++) {
    Console.WriteLine($"Inserire il {i+1}-esimo numero");
    test[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("--Array di partenza--");
StampaArray(test);
Console.WriteLine("--Array elevato al quadrato--");
int[] arrayElevato = ElevaArrayAlQuadrato(test);
StampaArray(arrayElevato);
Console.WriteLine("--Array di partenza dopo l'elevazione--");
StampaArray(test);
Console.WriteLine("--Array di partenza sommato--");
int arrayTestSommato = sommaElementiArray(test);
Console.WriteLine(arrayTestSommato);
Console.WriteLine("--Array elevato al quadrato sommato--");
int arrayElevatoSommato = sommaElementiArray(arrayElevato);
Console.WriteLine(arrayElevatoSommato);

