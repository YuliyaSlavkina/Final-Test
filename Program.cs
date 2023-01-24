 string[] array = {"jo", "hello", "77", "hej", "4" };

    
    
int FindSize(string[] array){
 int size = 0;
  for(int i = 0; i< array.Length; i++){
    if (array[i].Length < 4){
      size++;
    }     
  }
  return size;
}

string[] CreateArray(string[] array, int size){
  int j=0;
string[] resultArray = new string[size];
    for(int i = 0; i < array.Length; i++){
      if(array[i].Length < 4 ){
      resultArray[j] = array[i];        
       j++;
      }    
    }   
  return resultArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

       

    int size = FindSize(array);
    Console.Write("new array is [ ");
    ShowArray(CreateArray(array, size));
    Console.Write("]");