using System;
class Program
{
    static void Main(string[] args)
    {
       
        Stack<string> stack = new Stack<string>();
        Tree<string> tree = new Tree<string>();
        TreeNode<string> treeNode = null;
        string RootName = "Admin";
        tree.AddChild(-1,RootName);
        string AbsentName = "";
        string SiplingName = "";
        string GeneralName = "";
       string HeadName = Console.ReadLine();
        tree.AddChild(0,HeadName);
        int Headamount = int.Parse(Console.ReadLine());
        int amount = 0;
        int Siplingamount = 0;
        Manager(ref amount,ref Headamount, ref Siplingamount,ref tree,ref GeneralName, ref SiplingName);
        AbsentName = Console.ReadLine();
        tree.searcher(treeNode,AbsentName,ref stack);  
                 
                    
                   
                  
            
            
        
        
  
    }
    static void Manager(ref int amount,ref int Headamount ,ref int Siplingamount, ref Tree<string> tree, ref string GeneralName, ref string SiplingName)
    {
        for(int j = 1; j<=Headamount; j++)
            {
                //Console.Write("Input your General: ");
                GeneralName = Console.ReadLine();
                tree.AddChild(j,GeneralName);
                //Console.Write("Input your Lower amount: ");
                amount = int.Parse(Console.ReadLine());
                Lower(ref amount,ref Headamount ,ref Siplingamount, ref tree, ref GeneralName, ref SiplingName);
                
            }      
    }
    static void Lower(ref int amount,ref int Headamount ,ref int Siplingamount, ref Tree<string> tree, ref string GeneralName, ref string SiplingName)
    {
        for(int i =1; i<= amount; i++)
            {
                //Console.Write("Input your Lower: ");
                SiplingName = Console.ReadLine();
                tree.AddSibling(i,SiplingName);
                //Console.Write("Input your Lower Num: ");
                Siplingamount= int.Parse(Console.ReadLine());
                if(Siplingamount > 0) Manager(ref amount,ref Headamount ,ref Siplingamount, ref tree, ref GeneralName, ref SiplingName);
                
            }
    }
}