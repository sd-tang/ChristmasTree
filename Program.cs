using System;
using static System.Console;

namespace ChristmasTree
{
        class Program
    {
        static void Main(string[] args)
        {
            MyTree(3, 9);
        }

        static void MyTree(int smallestTree, int biggestTree)
        {
            int currentTree = smallestTree;

            while (currentTree <= biggestTree)
            {
                DrawTree(currentTree);
                currentTree++;
            }
        }

        static void DrawTree(int treeSize)
        {
            int whitespace = treeSize;

            for (int i = 1; i <= treeSize; i++)
            {
                printTree(i, whitespace);
                whitespace--;
            }
            printTree(1, treeSize);
            WriteLine();
        }

        static void printTree(int iteration, int numOfSpace)
        {
            string currentSpace = new String(' ', numOfSpace);
            string currentAsterisk = new String('*', iteration + (iteration - 1));
            WriteLine(currentSpace + currentAsterisk);
        }
    }
}
