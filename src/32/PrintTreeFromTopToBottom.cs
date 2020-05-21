﻿using System;
using System.Collections.Generic;

namespace CodingInterview {
    public class PrintTreeFromTopToBottom {
        public static void PrintFromTopToBottom(BinaryTreeNode root) {
            if (root == null) {
                return;
            }

            var queue = new Queue<BinaryTreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0) {
                BinaryTreeNode node = queue.Peek();
                queue.Dequeue();

                Console.WriteLine(node.Value);

                if (node.Left != null) {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null) {
                    queue.Enqueue(node.Right);
                }
            }
        }
    }
}
