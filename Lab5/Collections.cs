using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Collections
    {
        public void ArrayListDemo()
        {
            int choice;
            ArrayList arrayList = new ArrayList();
            do
            {
                Console.WriteLine("\n===== ArrayList Operation Programs =====");
                Console.WriteLine("1. Add() - To Add new student in list\r\n2. Remove() - To Remove Student with specified index\r\n. RemoveRange() - To Remove student with specified range.\r\nd. Clear() - To clear all the student from the list.\r\n5. Display");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                bool validInput = int.TryParse(Console.ReadLine(), out choice);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the student name to add: ");
                        string student = Console.ReadLine();
                        arrayList.Add(student);
                        break;
                    case 2:
                        Console.Write("Enter the index of the student to remove: ");
                        if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= arrayList.Count)
                        {
                            Console.WriteLine("Invalid index. Please try again.");
                            continue;
                        }
                        string studentToRemove = arrayList[index] as string;
                        if (studentToRemove == null)
                        {
                            Console.WriteLine("No student found at the specified index.");
                            continue;
                        }
                        Console.WriteLine($"Removing student: {studentToRemove}");
                        arrayList.RemoveAt(index);
                        break;

                    case 3:
                        Console.Write("Enter the starting index to remove range: ");
                        if (!int.TryParse(Console.ReadLine(), out int startIndex) || startIndex < 0 || startIndex >= arrayList.Count)
                        {
                            Console.WriteLine("Invalid starting index. Please try again.");
                            continue;
                        }
                        Console.Write("Enter the number of students to remove: ");
                        if (!int.TryParse(Console.ReadLine(), out int count) || count < 1 || startIndex + count > arrayList.Count)
                        {
                            Console.WriteLine("Invalid count. Please try again.");
                            continue;
                        }
                        Console.WriteLine($"Removing {count} students starting from index {startIndex}.");
                        arrayList.RemoveRange(startIndex, count);
                        break;

                    case 4:
                        arrayList.Clear();
                        break;

                    case 5:
                        Console.WriteLine("Current students in the list:");
                        if (arrayList.Count == 0)
                        {
                            Console.WriteLine("No students in the list.");
                        }
                        else
                        {
                            for (int i = 0; i < arrayList.Count; i++)
                            {
                                Console.WriteLine($"{i}: {arrayList[i]}");
                            }
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 0);

        }

        public void ListDemo()
        {
            int choice;

            List<string> studentList = new List<string>();

            do
            {
                Console.WriteLine("\n===== List Operation Programs =====");
                Console.WriteLine("a. Add() - To Add new student in list\r\nb. Remove() - To Remove Student with specified index\r\nc. RemoveRange() - To Remove student with specified range.\r\nd. Clear() - To clear all the student from the list\r\n5. Display");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                bool validInput = int.TryParse(Console.ReadLine(), out choice);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the student name to add: ");
                        string student = Console.ReadLine();
                        studentList.Add(student);
                        break;
                    case 2:

                        Console.Write("Enter the index of the student to remove: ");
                        if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= studentList.Count)
                        {
                            Console.WriteLine("Invalid index. Please try again.");
                            continue;
                        }
                        string studentToRemove = studentList[index];
                        Console.WriteLine($"Removing student: {studentToRemove}");
                        studentList.RemoveAt(index);
                        break;

                    case 3:
                        Console.Write("Enter the starting index to remove range: ");
                        if (!int.TryParse(Console.ReadLine(), out int startIndex) || startIndex < 0 || startIndex >= studentList.Count)
                        {
                            Console.WriteLine("Invalid starting index. Please try again.");
                            continue;
                        }
                        Console.Write("Enter the number of students to remove: ");
                        if (!int.TryParse(Console.ReadLine(), out int count) || count < 1 || startIndex + count > studentList.Count)
                        {
                            Console.WriteLine("Invalid count. Please try again.");
                            continue;
                        }
                        Console.WriteLine($"Removing {count} students starting from index {startIndex}.");
                        break;

                    case 4:
                        studentList.Clear();
                        break;

                    case 5:
                        Console.WriteLine("Current students in the list:");
                        for (int i = 0; i < studentList.Count; i++)
                        {
                            Console.WriteLine($"{i}: {studentList[i]}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 0);
        }

        public void StackDemo()
        {
            Stack<string> stack = new Stack<string>();
            int choice;
            do
            {
                Console.WriteLine("\n===== Stack Operation Programs =====");
                Console.WriteLine("1. Push() - To Add new student in stack\r\n2. Pop() - To Remove Student from top of the stack\r\n3. Peek() - To view the top student in the stack\r\n4. Clear() - To clear all the students from the stack\r\n5. Display");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                bool validInput = int.TryParse(Console.ReadLine(), out choice);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the student name to add: ");
                        string student = Console.ReadLine();
                        stack.Push(student);
                        break;
                    case 2:
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Stack is empty. Cannot pop.");
                            continue;
                        }
                        string removedStudent = stack.Pop();
                        Console.WriteLine($"Removed student: {removedStudent}");
                        break;
                    case 3:
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Stack is empty. Nothing to peek.");
                            continue;
                        }
                        string topStudent = stack.Peek();
                        Console.WriteLine($"Top student in the stack: {topStudent}");
                        break;
                    case 4:
                        stack.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Current students in the stack:");
                        foreach (var item in stack)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0);
        }

        public void QueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            int choice;
            do
            {
                Console.WriteLine("\n===== Queue Operation Programs =====");
                Console.WriteLine("1. Enqueue() - To Add new student in queue\r\n2. Dequeue() - To Remove Student from front of the queue\r\n3. Peek() - To view the front student in the queue\r\n4. Clear() - To clear all the students from the queue\r\n5. Display");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                bool validInput = int.TryParse(Console.ReadLine(), out choice);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the student name to add: ");
                        string student = Console.ReadLine();
                        queue.Enqueue(student);
                        break;
                    case 2:
                        if (queue.Count == 0)
                        {
                            Console.WriteLine("Queue is empty. Cannot dequeue.");
                            continue;
                        }
                        string removedStudent = queue.Dequeue();
                        Console.WriteLine($"Removed student: {removedStudent}");
                        break;
                    case 3:
                        if (queue.Count == 0)
                        {
                            Console.WriteLine("Queue is empty. Nothing to peek.");
                            continue;
                        }
                        string frontStudent = queue.Peek();
                        Console.WriteLine($"Front student in the queue: {frontStudent}");
                        break;
                    case 4:
                        queue.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Current students in the queue:");
                        foreach (var item in queue)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0);
        }

        public void DictionaryDemo()
        {
            Dictionary<int, string> studentDict = new Dictionary<int, string>();
            int choice;
            do
            {
                Console.WriteLine("\n===== Dictionary Operation Programs =====");
                Console.WriteLine("1. Add: Adds a key-value pair.\r\n2. Remove: Removes a key-value pair by key.\r\n3. ContainsKey: Checks if a key exists in the hashtable.\r\n4. ContainsValue: Checks if a value exists in the hashtable.\r\n5. Clear: Removes all key-value pairs.\r\n6. Display");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                bool validInput = int.TryParse(Console.ReadLine(), out choice);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the student ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine("Invalid ID. Please try again.");
                            continue;
                        }
                        Console.Write("Enter the student name: ");
                        string name = Console.ReadLine();
                        studentDict[id] = name;
                        break;
                    case 2:
                        Console.Write("Enter the student ID to remove: ");
                        if (!int.TryParse(Console.ReadLine(), out int removeId) || !studentDict.ContainsKey(removeId))
                        {
                            Console.WriteLine("Invalid ID. Please try again.");
                            continue;
                        }
                        studentDict.Remove(removeId);
                        Console.WriteLine($"Removed student with ID: {removeId}");
                        break;
                    case 3:
                        Console.Write("Enter the key: ");
                        int key = Convert.ToInt32(Console.ReadLine());

                        if (studentDict.ContainsKey(key))
                        {
                            Console.WriteLine($"Key {key} exists. Value: {studentDict[key]}");
                        }
                        else
                        {
                            Console.WriteLine($"Key {key} not found in the dictionary.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter the value: ");
                        string value = Console.ReadLine();

                        if (studentDict.ContainsValue(value))
                        {
                            Console.WriteLine($"Value \"{value}\" exists in the dictionary.");
                        }
                        else
                        {
                            Console.WriteLine($"Value \"{value}\" not found in the dictionary.");
                        }
                        break;

                    case 5:
                        studentDict.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Student List:");
                        foreach (KeyValuePair<int, string> kvp in studentDict)
                        {
                            Console.WriteLine("ID: {0}, Name: {1}", kvp.Key, kvp.Value);
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;


                }
            } while (choice != 0);
        }

        public void HashTableDemo()
        {
            Hashtable hashtable = new Hashtable();
            int choice = 0;

            do
            {
                Console.WriteLine("\n===== Dictionary Operation Programs =====");
                Console.WriteLine("1. Add: Adds a key-value pair.\r\n2. Remove: Removes a key-value pair by key.\r\n3. ContainsKey: Checks if a key exists in the hashtable.\r\n4. ContainsValue: Checks if a value exists in the hashtable.\r\n5. Clear: Removes all key-value pairs.\r\n6. Display");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                bool validInput = int.TryParse(Console.ReadLine(), out choice);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the student ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine("Invalid ID. Please try again.");
                            continue;
                        }

                        Console.Write("Enter the student name: ");
                        string name = Console.ReadLine();

                        if (!hashtable.ContainsKey(id))
                        {
                            hashtable.Add(id, name);
                            Console.WriteLine("Entry added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Key already exists. Cannot add duplicate key.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter the student ID to remove: ");
                        if (!int.TryParse(Console.ReadLine(), out int removeId))
                        {
                            Console.WriteLine("Invalid ID.");
                            continue;
                        }

                        if (hashtable.ContainsKey(removeId))
                        {
                            hashtable.Remove(removeId);
                            Console.WriteLine("Entry removed.");
                        }
                        else
                        {
                            Console.WriteLine("Key not found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter the key to check: ");
                        if (!int.TryParse(Console.ReadLine(), out int checkKey))
                        {
                            Console.WriteLine("Invalid key.");
                            continue;
                        }

                        if (hashtable.ContainsKey(checkKey))
                        {
                            Console.WriteLine("Key exists.");
                        }
                        else
                        {
                            Console.WriteLine("Key does not exist.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter the value to check: ");
                        string checkValue = Console.ReadLine();

                        if (hashtable.ContainsValue(checkValue))
                        {
                            Console.WriteLine("Value exists.");
                        }
                        else
                        {
                            Console.WriteLine("Value does not exist.");
                        }
                        break;

                    case 5:
                        hashtable.Clear();
                        Console.WriteLine("All entries cleared.");
                        break;

                    case 6:
                        Console.WriteLine("All student records:");
                        foreach (DictionaryEntry entry in hashtable)
                        {
                            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;

                }

            } while (choice != 0);
        }
    }
}
