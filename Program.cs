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