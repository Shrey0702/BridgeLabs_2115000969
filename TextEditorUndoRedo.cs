namespace ConsoleApp2;

using System;

class TextState{
    public string Content;
    public TextState Next;
    public TextState Prev;

    public TextState(string content){
        Content = content;
        Next = null;
        Prev = null;
    }
}

class TextEditor{
    private TextState head;
    private TextState current;
    private int historyLimit = 10;
    private int stateCount = 0;

    public void AddState(string content){
        TextState newState = new TextState(content);
        
        if (current != null){
            current.Next = newState;
            newState.Prev = current;
        }
        else{
            head = newState;
        }

        current = newState;
        stateCount++;
		
        if(stateCount > historyLimit){
            head = head.Next;
            head.Prev = null;
            stateCount--;
        }
    }

    public void Undo(){
        if(current!= null && current.Prev != null){
            current = current.Prev;
            Console.WriteLine("Undo: " + current.Content);
        }
        else{
            Console.WriteLine("undo actions not available");
        }
    }

    public void Redo(){
        if(current!= null && current.Next != null){
            current = current.Next;
            Console.WriteLine("Redo " + current.Content);
        }
        else{
            Console.WriteLine("redo actions not available.");
        }
    }

    public void DisplayCurrentState(){
        if(current!= null){
            Console.WriteLine("Current Text " + current.Content);
        }
        else{
            Console.WriteLine("No text available");
        }
    }
}

class TextEditorUndoRedo{
    public static void Main(string[] args){
        TextEditor editor = new TextEditor();
        editor.AddState("hello");
        editor.AddState("hello Namaste");
        editor.AddState("hello hola");
        editor.AddState("hello Bonjour");

        Console.WriteLine("Initial State");
        editor.DisplayCurrentState();

        Console.WriteLine("Performing Undo");
        editor.Undo();
        editor.Undo();
        
        Console.WriteLine("Performing Redo");
        editor.Redo();

        Console.WriteLine("Final State");
        editor.DisplayCurrentState();
    }
}
