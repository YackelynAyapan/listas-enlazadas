using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_vinculadas
{

   
        class Node
        {
            public Node prev { get; set; }
            public string name { get; set; }
            public Node next { get; set; }

            Node head = null;
            Node last = null;

            

            //insertFirst=("Mario"); insertLast("Main");
            public void insertFirst(string name)
            {
                var node = new Node();
                node.name = name;
                if (head != null)
                {
                    head.prev = node;
                    node.next = head;
                }
                head = node;
                if (last == null) 
                {
                    last = node;
                }
               
            }
            public void insertLast(string name)
            {
                var node = new Node();
                node.name = name;
                if (last != null)
                {
                    last.next = node;
                    node.prev = last;
                }
                last = node;
                if (head == null)
                {
                    head = node;
                }  
            }
            //Impresion de los datos 
            public void imprimir()
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.name);
                    current = current.next;
                }
            }

        //Modificar datos 
            public void Modificar()
            {
                Console.WriteLine("Ingrese el nombre que desea remplazar");
                string primero = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre para remplazarlo");
                string segundo = Console.ReadLine();
                Node current = head;


            
                while (current != null)
                {
                    if (current.name == primero)
                    {
                        
                        current.name = segundo;
                        
                        break;
                    }
                    current = current.next;
                }

            }
        //Borrar----
        public void Borrar()
        {
            string delete = Console.ReadLine();

            
            Node current = head;
            while (current != null)
            {
                if (current.name == delete)
                {
                    current.prev.next = current.next;
                    if (current.next != null)
                    {
                        current.next.prev = current.prev;
                    }
                    break;
                }
                else { }
                current = current.next;
            }
        }

    }
        
    }
     

