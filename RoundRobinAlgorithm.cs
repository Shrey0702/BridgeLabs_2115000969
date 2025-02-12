namespace ConsoleApp2;

using System;

class Process{
    public int ProcessID;
    public int BurstTime;
    public int Priority;
    public Process Next;

    public Process(int processID, int burstTime, int priority){
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler{
    private Process head;
    private Process tail;

    public void AddProcess(int processID, int burstTime, int priority){
        Process newProcess = new Process(processID, burstTime, priority);
        if(head == null){
            head = tail = newProcess;
            head.Next = head; 
            return;
        }
        tail.Next = newProcess;
        newProcess.Next = head;
        tail = newProcess;
    }

    public void RemoveProcess(int processID){
        if(head == null){
            Console.WriteLine("No processes available.");
            return;
        }

        Process temp = head, prev = null;
        do{
            if (temp.ProcessID == processID){
                if (prev != null){
                    prev.Next = temp.Next;
                    if (temp == head)
                        head = temp.Next;
                    if (temp == tail)
                        tail = prev;
                }
                else{
                    if (head == tail){
                        head = null;
                        tail = null;
                    }
                    else{
                        tail.Next = head.Next;
                        head = head.Next;
                    }
                }
                Console.WriteLine("Process " + processID + " has completed execution.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void DisplayProcesses(){
        if (head == null){
            Console.WriteLine("No processes in the queue.");
            return;
        }
        Process temp = head;
        do{
            Console.WriteLine("Process ID: " + temp.ProcessID + ", Burst Time: " + temp.BurstTime + ", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != head);
    }

    public void RoundRobinScheduling(int timeQuantum){
        if (head == null){
            Console.WriteLine("No processes to schedule.");
            return;
        }

        int totalWaitingTime = 0, totalTurnaroundTime = 0, processCount = 0;
        Process current = head;

        Console.WriteLine("\nExecuting Processes using Round Robin Scheduling (Time Quantum = " + timeQuantum + "):");
        while (head != null)
        {
            Process temp = head;
            do
            {
                if (temp.BurstTime > 0)
                {
                    int executionTime = Math.Min(temp.BurstTime, timeQuantum);
                    Console.WriteLine("Executing Process " + temp.ProcessID + " for " + executionTime + " units.");

                    temp.BurstTime -= executionTime;
                    totalTurnaroundTime += executionTime;

                    if (temp.BurstTime == 0)
                    {
                        RemoveProcess(temp.ProcessID);
                        totalWaitingTime += totalTurnaroundTime;
                        processCount++;
                    }
                }
                temp = temp.Next;
            } while (temp != head);
        }

        double avgWaitingTime = (double)totalWaitingTime / processCount;
        double avgTurnaroundTime = (double)totalTurnaroundTime / processCount;

        Console.WriteLine("\nAverage Waiting Time: " + avgWaitingTime);
        Console.WriteLine("Average Turnaround Time: " + avgTurnaroundTime);
    }
}

class RoundRobinAlgorithm{
    public static void Main(string[] args){
        RoundRobinScheduler scheduler = new RoundRobinScheduler();

        scheduler.AddProcess(1, 8, 1);
        scheduler.AddProcess(2, 4, 2);
        scheduler.AddProcess(3, 9, 1);
        scheduler.AddProcess(4, 5, 3);

        Console.WriteLine("Initial Process Queue");
        scheduler.DisplayProcesses();

        int timeQuantum = 3;
        scheduler.RoundRobinScheduling(timeQuantum);
    }
}
