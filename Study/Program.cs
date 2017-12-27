using System;
using Ninject;
using Study.Services;
using Study.Services.Utility;
using Study.Application.DataStructures.LinkedLists;
using Study.Application.DataStructures.Arrays;
using Study.Models.Trees;
using System.Reflection;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            kernel.Get<IArrayService>();
            kernel.Get<IArrayUtility>();
            kernel.Get<IGlobalUtility>();
            kernel.Get<IBinaryTreeUtility>();

            var app = kernel.Get<IBinaryTreeUtility>();
            BinaryTreeNode root = new BinaryTreeNode(1)
            {
                Left = new BinaryTreeNode(2)
                {
                    Left = new BinaryTreeNode(4),
                    Right = new BinaryTreeNode(5)
                },
                Right = new BinaryTreeNode(3)
                {
                    Left = new BinaryTreeNode(6),
                    Right = new BinaryTreeNode(7)
                }
            };
            app.LevelOrderPrint(root);
            Console.ReadLine();
        }
    }
}
