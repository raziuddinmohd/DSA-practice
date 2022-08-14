// See https://aka.ms/new-console-template for more information
using DSA_algorithm.LinkedList;

Console.WriteLine("Hello, World!");


Node NodeA = new Node();
NodeA.Data = 4665;

Node NodeB= new Node();
NodeB.Data = 7897;

Node NodeC=new Node();
NodeC.Data = 879;

Node NodeD=new Node();
NodeD.Data = 324234;


NodeA.Next = NodeB;
NodeB.Next = NodeC;
NodeC.Next = NodeD;