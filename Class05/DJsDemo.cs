// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Runtime.CompilerServices;
// using System.Security.Cryptography.X509Certificates;
// using System.Text;
// using System.Threading.Tasks;

// namespace LinkedList_Implementation_Solution
// {
// 	public class OurLinkedList
// 	{
// 		internal OurNode Head { get; set; }
		
// 		public OurLinkedList() {
// 			Head = new OurNode();
// 		}
// 		public OurLinkedList(List<OurNode> nodes)
// 		{
// 			Head = new OurNode();
// 			//Add All implementation
			
// 		}

// 		public void AddFirst (OurNode node) {
// 			Head = node;
// 			Head.Next = node.Next;
// 		}

// 		public void AddLast (OurNode node) {
// 			// check our head to make sure we have one
// 			// iterate through that chain of next to see if we have any additional nodes
// 			if(Head.Next == null)
// 			{
// 				Head.Next = node;
// 			}
// 			else
// 			{
// 				OurNode Current = Head.Next;
// 				// iterate through what we have
// 				while(Head.Next != null)
// 				{
// 					node.Next();
// 				}
// 			}
// 		}


// 	}

// 	public class OurNode
// 	{
// 		public string Info { get; set; }
// 		public OurNode Next { get; set; }
// 		//OurNode Prev;
// 		public OurNode()
// 		{
// 			Info = "";
// 			Next = null;
// 		}
// 		public OurNode(string info)
// 		{
// 			Info = info;
// 			Next = null;
// 		}
// 		public OurNode(string info, OurNode next)
// 		{
// 			Info = info;
// 			Next = next;
// 		}
// 	}
// }