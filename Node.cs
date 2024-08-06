using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Node
    {
        private int? _value;
        private Node _next;

        public Node()
        {
            this.setValue(null);
            this.setNext(null);
        }

        public Node(int value)
        {
            this.setValue(value); ;
            this.setNext(null);
        }

        public Node(int value, Node next)
        {
            this.setValue(value); ;
            this.setNext(next);
        }

        public void setValue(int? value) {
            this._value = value;
        }

        public void setNext(Node next)
        {
            this._next = next;
        }

        public int? getValue()
        {
            return this._value;
        }

        public Node getNext() {
            return this._next;
        }

        public override string ToString()
        {
            // un ari
            // bi nari
            // tri nari
            // a + b > 5 ? true : false
            string hasNext = this.getNext() != null ? "has" : "no";
            return $"Value is {this.getValue()}, {hasNext} Next";
        }
    }
}
