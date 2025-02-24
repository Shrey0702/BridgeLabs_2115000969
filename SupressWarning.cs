using System;
using System.Collections;
class SupressWarning{   
    //making the warning manually,no default warning
    [Obsolete("Warning!!!")]
    //method to add items
    static void StoreItems<T>(ArrayList list,T item){
        list.Add(item);
    }
    //Main method
    static void Main(){
        ArrayList list = new ArrayList(); 
        //Disabling the warnings
        #pragma warning disable
        StoreItems(list,"Shrey");
        StoreItems(list,62);
        foreach (var item in list){
            Console.WriteLine(item);
        }
        
    }
}

