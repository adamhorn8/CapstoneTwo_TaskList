using System;
using System.Collections.Generic;

namespace Capstone2_TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool whileBool = true;
            string response = "";

            string TaskOwner = "";
            string NameofTask = "";
            string DueDate = "";
            bool Complete = false;

            List<AddTask> TaskList = new List<AddTask>();
            Console.WriteLine("Welcome to the Task Manager!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. List Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Mark Task Complete");
                Console.WriteLine("5. Quit");
                Console.WriteLine();
                Console.WriteLine("What would you like to do? (Please enter 1-5)");
                string LikeToDo = Console.ReadLine();

                if (LikeToDo == "1")
                {
                    int Count = 0;

                    Console.WriteLine();
                    Console.WriteLine($"   Complete? \t Due Date: \t Team Member: \t Task Name:");

                    foreach (var Item in TaskList)
                    {
                        Count++;
                        Console.WriteLine($"{Count}. {Item.Complete} \t {Item.DueDate}  \t {Item.TaskOwner} \t\t {Item.TaskName}");

                    }
                }
                else if (LikeToDo == "2")
                {
                    whileBool = true;

                    while (whileBool)
                    {
                        Console.WriteLine();
                        Console.WriteLine("What is the name of the Team Member that is responsible for this task?");
                        TaskOwner = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("What is the name of this task?");
                        NameofTask = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("What is the due date of this task?");
                        DueDate = Console.ReadLine();

                        TaskList.Add(new AddTask(Complete,TaskOwner,NameofTask,DueDate));

                        Console.WriteLine();
                        Console.WriteLine("This task has been added to the list");
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Would you like to add another task? (Y/N)");
                            response = Console.ReadLine().ToUpper();
                            if (response == "N")
                            {
                                whileBool = false;
                                break;
                            }
                            else if (response == "Y")
                            {
                                whileBool = true;
                                break;
                            }
                            else
                            {   
                                Console.WriteLine();
                                Console.WriteLine("Sorry I didn't get that can you try again?");
                            }
                        }
                    }
                }
                else if (LikeToDo == "3")
                {
                    
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Which task number would you like to delete?");
                        string RemoveS = Console.ReadLine();
                        int Remove = 0;
                        bool RemoveB = int.TryParse(RemoveS, out Remove);

                        if (RemoveB == true && Remove <= TaskList.Count)
                        {
                            Remove = (Remove - 1);
                            Console.WriteLine();
                            Console.WriteLine($"Are you sure you would like to delete {($"{TaskList[Remove].TaskName}")}(Y/N)");
                            string SureDelete = Console.ReadLine().ToLower();

                            if (SureDelete == "y")
                            {
                                Console.WriteLine("The task has been removed");
                                TaskList.RemoveAt(Remove);
                                break;
                            }
                            else if (SureDelete == "n")
                            {
                                Console.WriteLine("Ok I won't delete that task");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sorry I didn't get that, please try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sorry that was not a valid task number, try again");
                        }
                    }
                }
                else if (LikeToDo == "4")
                {
                    int Count = 0;
                    Console.WriteLine();
                    Console.WriteLine($"   Complete? \t Due Date: \t Team Member: \t Task Name:");

                    foreach (var Item in TaskList)
                    {
                        Count++;
                        Console.WriteLine($"{Count}. {Item.Complete} \t {Item.DueDate}  \t {Item.TaskOwner} \t\t {Item.TaskName}");

                    }

                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Which task number would you like to mark complete?");
                        string CompleteNumS = Console.ReadLine();
                        int CompleteNum = 0;
                        bool CompleteNumB = int.TryParse(CompleteNumS, out CompleteNum);

                        if (CompleteNumB == true)
                        {
                            CompleteNum = (CompleteNum - 1);
                            TaskList[CompleteNum].Complete = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sorry that was not a valid task number, try again");
                        }
                    }

                }
                else if (LikeToDo == "5")
                {
                    Console.WriteLine("Are you sure you want to quit? (Y/N)");
                    string SureQuit = Console.ReadLine().ToLower();
                    if (SureQuit == "y")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks for using the Task List!");
                        break;
                    }
                    else
                    {

                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry that was not a valid input");
                    Console.WriteLine();
                }
            }
        }
    }
}